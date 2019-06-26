using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Maut
{
    class Alternative
    {
        private string name;
        private string parameter;
        private double value;
        private double utility; 

        public Alternative(string name, string parameter, double value)
        {
            this.name = name;
            this.parameter = parameter;
            this.value = value;
        }

        public string getName()
        {
            return name;
        }
        public double setUtility(Chart graph)
        {
            double x = 0;
            string s;
            
            
            for (int i = 0; i < graph.Series[0].Points.Count; i++)
            {
                if (value % 1 == 0)
                {                 
                    x = graph.Series[0].Points[i].XValue;
                    s = x.ToString();
                    x = Double.Parse(s);
                    if (x == value)
                    {
                        utility = graph.Series[0].Points[i].YValues[0];
                        return Math.Round(utility, 3);
                    }
                }
                else
                {
                    x = graph.Series[0].Points[i].XValue;
                   
                    if (x == value)
                    {
                        utility = graph.Series[0].Points[i].YValues[0];
                        return Math.Round(utility, 3);
                    }

                }
            }
            return 0;
        }     
        public void findUtilityLocation(ref int rowIndex, ref int columnIndex, string leafName,DataGridView utilityTable)
        {
            foreach (DataGridViewColumn col in utilityTable.Columns)
            {
                if (col.HeaderText == name)
                    columnIndex = col.Index;
            }

            for(int i=0; i<utilityTable.RowCount; i++)
            {
                if (utilityTable[0, i].Value.ToString() == leafName)
                    rowIndex = i;
            }


        }
        public double calculate(TreeNode node,DataGridView utilityTable)
        {
            int alternativeIndex = 0;
            int rowIndex = 0;
                                
            double weight = Double.Parse(node.Tag.ToString());
            double leafValue = 0;
            if (node.Nodes.Count == 0)
            {
                findUtilityLocation(ref rowIndex, ref alternativeIndex, node.Name, utilityTable);
                leafValue = Double.Parse(utilityTable[alternativeIndex, rowIndex].Value.ToString()) * weight;
                return leafValue;
            }
            else
            {
                double sum = 0;
                foreach (TreeNode treeNode in node.Nodes)
                {
                    sum+= weight*calculate(treeNode,utilityTable);
                }
                return sum;
            }
        }

    }
            


    }


