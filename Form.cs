using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms.DataVisualization.Charting;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Maut
{
    public partial class Form1 : Form
    {
        private Alternative[] alternatives;       
        private List<UtilityFunction> utilityFunctions = new List<UtilityFunction>();

        public Form1()
        {
            InitializeComponent();

        }
        private List<TreeNode> GetAllNodes(TreeNode self)
        {
            List<TreeNode> result = new List<TreeNode>();
            result.Add(self);
            foreach (TreeNode child in self.Nodes)
            {
                result.AddRange(GetAllNodes(child));
            }
            return result;
        } 

        private List<TreeNode> returnAllLeafs(TreeNode node)
        {
            List<TreeNode> leafNodes = new List<TreeNode>();

            if(node.Nodes.Count == 0)
            {
                leafNodes.Add(node);
            }
            else
            {
                foreach (TreeNode child in node.Nodes)
                    leafNodes.AddRange(returnAllLeafs(child));              
            }
            return leafNodes;
            
            }
 
        private double calculateSumWeightsOfChildren(TreeNode selected)
        {
            double sum = 0;
            int s = selected.GetNodeCount(false);
            if (s == 0)
                return 0;
            String t;
            foreach (TreeNode tn in selected.Nodes)
            {
                if (tn.Level != 0 && tn.Level == selected.Level + 1)
                {
                    t = tn.Tag.ToString();
                    sum += Double.Parse(t);
                }
            }
            return sum;
        }
        private string readValue()
        {
            string value = Interaction.InputBox("Vnesite utež parametera (med 0 in 1)", "Vnašanje uteži", "", -1, -1);
            while ((double.Parse(value) < 0 || double.Parse(value) > 1))
                value = readValue();
            return value;
        }
        private void AddChildButton_Click(object sender, EventArgs e)
        {
            TreeNode selectedNode = treeView.SelectedNode;
            double sumOfChildren = 0;
            while (sumOfChildren != 1)
            {
                string parameter = Interaction.InputBox("Vnesite parameter", "Vnašanje parametrov", "", -1, -1);
                
                string value = readValue();

                while (sumOfChildren + double.Parse(value) > 1)
                    value = readValue();

                TreeNode newChild = new TreeNode();
                newChild.Name = parameter;
                newChild.Tag = value;
                newChild.Text = parameter + " " + newChild.Tag;

                treeView.SelectedNode.Nodes.Add(newChild);
                sumOfChildren = double.Parse(calculateSumWeightsOfChildren(treeView.SelectedNode).ToString());
            }
        }
        private int findRowIndex(string parameter)
        {
            int row = 0;
            for (int i = 0; i < AlternativeTable.RowCount; i++)
            {
                if (AlternativeTable[0, i].Value.ToString() == parameter)
                {
                    row = i;
                }

            }
            return row;
        }
        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (!isLeaf(treeView.SelectedNode.Name))
            {
                MessageBox.Show("Izbrani parameter ni list", "Opozorilo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Stop);
                return;
            }
            FormForFunctionAdding.Visible = true;
            utilityGraph.Series.Clear();
            
            foreach(UtilityFunction function in utilityFunctions)
            {
                if (function.getName() == treeView.SelectedNode.Name)
                {
                    utilityGraph.Series.Add(new Series());
                    function.drawFunction(utilityGraph);
                    lowerBound.Text = utilityGraph.ChartAreas[0].AxisX.Minimum.ToString();
                    upperBound.Text = utilityGraph.ChartAreas[0].AxisX.Maximum.ToString();
                    typeOfFunction.SelectedItem = function.getFunctionType();
                    n.Text = function.returnN().ToString();
                    incline.SelectedItem = function.returnIncline();
                }
            }
        }
        private void addAlternativeButton_Click(object sender, EventArgs e)
        {
            String alternative = Interaction.InputBox("Vnesite alternativo", "Vnašanje alternative", "", -1, -1);
            AlternativeTable.Columns.Add(alternative, alternative);
            UtilityTable.Columns.Add(alternative, alternative);
        }

        private void fillUtilityTable()
        {
            alternatives = new Alternative[AlternativeTable.ColumnCount - 1];
            int rowIndex = findRowIndex(treeView.SelectedNode.Name);
            ArrayList listOfUtilities = new ArrayList();

            for (int i = 1; i < AlternativeTable.Columns.Count; i++)
            {
                alternatives[i - 1] = new Alternative(AlternativeTable.Columns[i].HeaderText, treeView.SelectedNode.Name, double.Parse(AlternativeTable[i, rowIndex].Value.ToString()));
                listOfUtilities.Add(alternatives[i - 1].setUtility(utilityGraph));

            }
            for (int i = 1; i < listOfUtilities.Count + 1; i++)
            {
                UtilityTable[i, rowIndex].Value = listOfUtilities[i - 1];
            }
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            utilityGraph.Series.Clear();

            utilityGraph.Series.Add(new Series(treeView.SelectedNode.Name));
            List<TreeNode> leafs = returnAllLeafs(treeView.Nodes[0]);
                        
            string functionType = typeOfFunction.SelectedItem.ToString();

            UtilityFunction function = new UtilityFunction(treeView.SelectedNode.Name,
                Double.Parse(lowerBound.Text), Double.Parse(upperBound.Text),
                incline.SelectedItem.ToString(), double.Parse(this.n.Text),functionType);

            function.drawFunction(utilityGraph);
            fillUtilityTable();
            utilityFunctions.Add(function);      
            utilityGraph.SaveImage("Chart"+treeView.SelectedNode.Name+".png", ChartImageFormat.Png);
                                            
        }
        private void calculateButton_Click(object sender, EventArgs e)
        {
            alternativesGrades.Items.Clear();
            treeView.Nodes[0].Tag = 1;
            double grade = 0;
            double max = -1000;
            int maxIndex = 0;
            for (int i = 0; i < alternatives.Length; i++)
            {
                grade = alternatives[i].calculate(treeView.Nodes[0],UtilityTable);

                alternativesGrades.Items.Add(alternatives[i].getName() + ": " + grade.ToString() + "\n");
                comparingAlternativesChart.Series[0].Points.AddXY(alternatives[i].getName(), grade);

                if (grade > max)
                {
                    max = grade;
                    maxIndex = alternativesGrades.Items[i].Index;
                }
            }

            alternativesGrades.Items[maxIndex].ForeColor = Color.Green;            
        }

        private bool isLeaf(string p)
        {
            List<TreeNode> leafs = returnAllLeafs(treeView.Nodes[0]);
           
                for (int j = 0; j < leafs.Count; j++)
                {
                    if (p == leafs[j].Name)
                        return true;
                }
                        
            return false;
        }
        private void ShowAlternativesTableButton_Click(object sender, EventArgs e)
        {
            bool leafAlreadyExists = false;       
            List<TreeNode> leafs = returnAllLeafs(treeView.Nodes[0]);
            for (int i = 0; i < AlternativeTable.RowCount; i++) {
                if (!isLeaf(AlternativeTable[0, i].Value.ToString()))
                {
                    AlternativeTable.Rows.RemoveAt(i);
                    UtilityTable.Rows.RemoveAt(i);
                }

             }
           for(int i=0; i<leafs.Count; i++) //dodajanje novih listov
           {
               for(int j=0; j<AlternativeTable.RowCount; j++)
               {
                   if (AlternativeTable[0, j].Value.ToString() == leafs[i].Name)                    
                       leafAlreadyExists = true;                                 
               }
               if (!leafAlreadyExists)
               {                   
                   AlternativeTable.Rows.Add(leafs[i].Name);
                   UtilityTable.Rows.Add(leafs[i].Name);                 
               }
               leafAlreadyExists = false;
           }               
           AlternativeTable.Visible = true;
      } 

    }
}





