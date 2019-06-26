namespace Maut
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Ocena");
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.treeView = new System.Windows.Forms.TreeView();
            this.AddChildToOcenaButton = new System.Windows.Forms.Button();
            this.AlternativesButton = new System.Windows.Forms.Button();
            this.utilityGraph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.FormForFunctionAdding = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.incline = new System.Windows.Forms.ComboBox();
            this.OKButton = new System.Windows.Forms.Button();
            this.n = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.typeOfFunction = new System.Windows.Forms.ComboBox();
            this.upperBound = new System.Windows.Forms.TextBox();
            this.lowerBound = new System.Windows.Forms.TextBox();
            this.AlternativeTable = new System.Windows.Forms.DataGridView();
            this.ParameterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addAlternativeButton = new System.Windows.Forms.Button();
            this.UtilityTable = new System.Windows.Forms.DataGridView();
            this.FirstColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calculateButton = new System.Windows.Forms.Button();
            this.alternativesGrades = new System.Windows.Forms.ListView();
            this.alternativesBox = new System.Windows.Forms.GroupBox();
            this.UtilityBox = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comparingAlternativesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.utilityGraph)).BeginInit();
            this.FormForFunctionAdding.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativeTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UtilityTable)).BeginInit();
            this.alternativesBox.SuspendLayout();
            this.UtilityBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comparingAlternativesChart)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.Location = new System.Drawing.Point(123, 3);
            this.treeView.Name = "treeView";
            treeNode2.Name = "rootNode";
            treeNode2.Text = "Ocena";
            this.treeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView.Size = new System.Drawing.Size(485, 171);
            this.treeView.TabIndex = 0;
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_NodeMouseDoubleClick);
            // 
            // AddChildToOcenaButton
            // 
            this.AddChildToOcenaButton.Location = new System.Drawing.Point(46, 12);
            this.AddChildToOcenaButton.Name = "AddChildToOcenaButton";
            this.AddChildToOcenaButton.Size = new System.Drawing.Size(38, 28);
            this.AddChildToOcenaButton.TabIndex = 1;
            this.AddChildToOcenaButton.Text = "+";
            this.AddChildToOcenaButton.UseVisualStyleBackColor = true;
            this.AddChildToOcenaButton.Click += new System.EventHandler(this.AddChildButton_Click);
            // 
            // AlternativesButton
            // 
            this.AlternativesButton.Location = new System.Drawing.Point(26, 46);
            this.AlternativesButton.Name = "AlternativesButton";
            this.AlternativesButton.Size = new System.Drawing.Size(75, 43);
            this.AlternativesButton.TabIndex = 2;
            this.AlternativesButton.Text = "Alternative";
            this.AlternativesButton.UseVisualStyleBackColor = true;
            this.AlternativesButton.Click += new System.EventHandler(this.ShowAlternativesTableButton_Click);
            // 
            // utilityGraph
            // 
            chartArea3.AxisX.Title = "Vrednost";
            chartArea3.AxisY.Maximum = 1D;
            chartArea3.AxisY.Minimum = 0D;
            chartArea3.AxisY.Title = "Koristnost";
            chartArea3.Name = "ChartArea1";
            this.utilityGraph.ChartAreas.Add(chartArea3);
            this.utilityGraph.Location = new System.Drawing.Point(220, 19);
            this.utilityGraph.Name = "utilityGraph";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Name = "Series1";
            this.utilityGraph.Series.Add(series3);
            this.utilityGraph.Size = new System.Drawing.Size(431, 275);
            this.utilityGraph.TabIndex = 3;
            this.utilityGraph.Text = "chart1";
            // 
            // FormForFunctionAdding
            // 
            this.FormForFunctionAdding.Controls.Add(this.label6);
            this.FormForFunctionAdding.Controls.Add(this.incline);
            this.FormForFunctionAdding.Controls.Add(this.utilityGraph);
            this.FormForFunctionAdding.Controls.Add(this.OKButton);
            this.FormForFunctionAdding.Controls.Add(this.n);
            this.FormForFunctionAdding.Controls.Add(this.label4);
            this.FormForFunctionAdding.Controls.Add(this.label3);
            this.FormForFunctionAdding.Controls.Add(this.label2);
            this.FormForFunctionAdding.Controls.Add(this.label1);
            this.FormForFunctionAdding.Controls.Add(this.typeOfFunction);
            this.FormForFunctionAdding.Controls.Add(this.upperBound);
            this.FormForFunctionAdding.Controls.Add(this.lowerBound);
            this.FormForFunctionAdding.Location = new System.Drawing.Point(12, 204);
            this.FormForFunctionAdding.Name = "FormForFunctionAdding";
            this.FormForFunctionAdding.Size = new System.Drawing.Size(681, 310);
            this.FormForFunctionAdding.TabIndex = 4;
            this.FormForFunctionAdding.TabStop = false;
            this.FormForFunctionAdding.Text = "Izberite naslednje lastnosti željene funkcije";
            this.FormForFunctionAdding.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "naraščanje/padanje";
            // 
            // incline
            // 
            this.incline.FormattingEnabled = true;
            this.incline.Items.AddRange(new object[] {
            "Naraščajoča",
            "Padajoča"});
            this.incline.Location = new System.Drawing.Point(6, 234);
            this.incline.Name = "incline";
            this.incline.Size = new System.Drawing.Size(121, 21);
            this.incline.TabIndex = 9;
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(6, 273);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 8;
            this.OKButton.Text = "Izriši funkcijo";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // n
            // 
            this.n.Location = new System.Drawing.Point(3, 186);
            this.n.Name = "n";
            this.n.Size = new System.Drawing.Size(100, 20);
            this.n.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip funkcije";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Zgornja meja intervala";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Spodnja meja intervala";
            // 
            // typeOfFunction
            // 
            this.typeOfFunction.FormattingEnabled = true;
            this.typeOfFunction.Items.AddRange(new object[] {
            "Eksponentna",
            "Linearna",
            "Logaritemska"});
            this.typeOfFunction.Location = new System.Drawing.Point(3, 141);
            this.typeOfFunction.Name = "typeOfFunction";
            this.typeOfFunction.Size = new System.Drawing.Size(121, 21);
            this.typeOfFunction.Sorted = true;
            this.typeOfFunction.TabIndex = 2;
            this.typeOfFunction.Tag = "";
            // 
            // upperBound
            // 
            this.upperBound.Location = new System.Drawing.Point(3, 92);
            this.upperBound.Name = "upperBound";
            this.upperBound.Size = new System.Drawing.Size(100, 20);
            this.upperBound.TabIndex = 1;
            // 
            // lowerBound
            // 
            this.lowerBound.Location = new System.Drawing.Point(6, 49);
            this.lowerBound.Name = "lowerBound";
            this.lowerBound.Size = new System.Drawing.Size(100, 20);
            this.lowerBound.TabIndex = 0;
            // 
            // AlternativeTable
            // 
            this.AlternativeTable.AllowUserToAddRows = false;
            this.AlternativeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AlternativeTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ParameterColumn});
            this.AlternativeTable.Location = new System.Drawing.Point(25, 43);
            this.AlternativeTable.Name = "AlternativeTable";
            this.AlternativeTable.RowHeadersVisible = false;
            this.AlternativeTable.Size = new System.Drawing.Size(400, 175);
            this.AlternativeTable.TabIndex = 5;
            // 
            // ParameterColumn
            // 
            this.ParameterColumn.HeaderText = "Parameter";
            this.ParameterColumn.Name = "ParameterColumn";
            this.ParameterColumn.ReadOnly = true;
            // 
            // addAlternativeButton
            // 
            this.addAlternativeButton.Location = new System.Drawing.Point(442, 43);
            this.addAlternativeButton.Name = "addAlternativeButton";
            this.addAlternativeButton.Size = new System.Drawing.Size(73, 46);
            this.addAlternativeButton.TabIndex = 6;
            this.addAlternativeButton.Text = "Dodaj alternatvo";
            this.addAlternativeButton.UseVisualStyleBackColor = true;
            this.addAlternativeButton.Click += new System.EventHandler(this.addAlternativeButton_Click);
            // 
            // UtilityTable
            // 
            this.UtilityTable.AllowUserToAddRows = false;
            this.UtilityTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UtilityTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FirstColumn});
            this.UtilityTable.Location = new System.Drawing.Point(25, 39);
            this.UtilityTable.Name = "UtilityTable";
            this.UtilityTable.RowHeadersVisible = false;
            this.UtilityTable.Size = new System.Drawing.Size(400, 168);
            this.UtilityTable.TabIndex = 7;
            // 
            // FirstColumn
            // 
            this.FirstColumn.HeaderText = "Parameter";
            this.FirstColumn.Name = "FirstColumn";
            this.FirstColumn.ReadOnly = true;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(123, 105);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(85, 34);
            this.calculateButton.TabIndex = 9;
            this.calculateButton.Text = "Izračunaj vrednosti alternativ";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // alternativesGrades
            // 
            this.alternativesGrades.Location = new System.Drawing.Point(17, 27);
            this.alternativesGrades.Name = "alternativesGrades";
            this.alternativesGrades.Size = new System.Drawing.Size(286, 73);
            this.alternativesGrades.TabIndex = 10;
            this.alternativesGrades.UseCompatibleStateImageBehavior = false;
            // 
            // alternativesBox
            // 
            this.alternativesBox.Controls.Add(this.AlternativeTable);
            this.alternativesBox.Controls.Add(this.addAlternativeButton);
            this.alternativesBox.Location = new System.Drawing.Point(711, 3);
            this.alternativesBox.Name = "alternativesBox";
            this.alternativesBox.Size = new System.Drawing.Size(544, 225);
            this.alternativesBox.TabIndex = 13;
            this.alternativesBox.TabStop = false;
            this.alternativesBox.Text = "Alternative";
            // 
            // UtilityBox
            // 
            this.UtilityBox.Controls.Add(this.UtilityTable);
            this.UtilityBox.Location = new System.Drawing.Point(711, 237);
            this.UtilityBox.Name = "UtilityBox";
            this.UtilityBox.Size = new System.Drawing.Size(544, 234);
            this.UtilityBox.TabIndex = 14;
            this.UtilityBox.TabStop = false;
            this.UtilityBox.Text = "Koristnost";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alternativesGrades);
            this.groupBox2.Controls.Add(this.calculateButton);
            this.groupBox2.Location = new System.Drawing.Point(711, 477);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 143);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ocene alternativ";
            // 
            // comparingAlternativesChart
            // 
            chartArea4.Name = "ChartArea1";
            this.comparingAlternativesChart.ChartAreas.Add(chartArea4);
            this.comparingAlternativesChart.Location = new System.Drawing.Point(1032, 471);
            this.comparingAlternativesChart.Name = "comparingAlternativesChart";
            series4.ChartArea = "ChartArea1";
            series4.Name = "Series1";
            this.comparingAlternativesChart.Series.Add(series4);
            this.comparingAlternativesChart.Size = new System.Drawing.Size(223, 149);
            this.comparingAlternativesChart.TabIndex = 16;
            this.comparingAlternativesChart.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1334, 628);
            this.Controls.Add(this.comparingAlternativesChart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.UtilityBox);
            this.Controls.Add(this.alternativesBox);
            this.Controls.Add(this.FormForFunctionAdding);
            this.Controls.Add(this.AlternativesButton);
            this.Controls.Add(this.AddChildToOcenaButton);
            this.Controls.Add(this.treeView);
            this.Name = "Form1";
            this.Text = "Form1";     
            ((System.ComponentModel.ISupportInitialize)(this.utilityGraph)).EndInit();
            this.FormForFunctionAdding.ResumeLayout(false);
            this.FormForFunctionAdding.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlternativeTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UtilityTable)).EndInit();
            this.alternativesBox.ResumeLayout(false);
            this.UtilityBox.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comparingAlternativesChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button AddChildToOcenaButton;
        private System.Windows.Forms.Button AlternativesButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart utilityGraph;
        private System.Windows.Forms.GroupBox FormForFunctionAdding;
        private System.Windows.Forms.ComboBox typeOfFunction;
        private System.Windows.Forms.TextBox upperBound;
        private System.Windows.Forms.TextBox lowerBound;
        private System.Windows.Forms.DataGridView AlternativeTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParameterColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox n;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addAlternativeButton;
        private System.Windows.Forms.DataGridView UtilityTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstColumn;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox incline;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ListView alternativesGrades;
        private System.Windows.Forms.GroupBox alternativesBox;
        private System.Windows.Forms.GroupBox UtilityBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart comparingAlternativesChart;
    }
}

