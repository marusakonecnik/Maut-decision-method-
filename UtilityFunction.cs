using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Maut
{
    class UtilityFunction
    {
        private string name;
        private double lowerLimit;
        private double upperLimit;          
        string incline;
        private double n;
        string functionType;
        
        

        public UtilityFunction(string name, double lowerLimit, double upperLimit,string incline,double n,string functionType)
        {
            this.name = name;
            this.lowerLimit = lowerLimit;
            this.upperLimit = upperLimit;                   
            this.incline = incline;
            this.n = n;
            this.functionType = functionType;
        }

        public string getName() { return name; }
        
        public string getFunctionType() { return functionType; }
        
        public double returnN() { return n; }

        public string returnIncline() { return incline; }


        public void drawFunction(Chart graph)
        {
            if (functionType == "Eksponentna")
                drawExponentFunction(graph);

            else if (functionType == "Linearna")
                drawLinearFunction(graph);

            else
                drawLogarithmFunction(graph);
        }

        private void drawExponentFunction(Chart graph)
        {         
            graph.Series[0].ChartType = SeriesChartType.Spline;
            graph.ChartAreas[0].AxisX.Maximum = upperLimit;
            graph.ChartAreas[0].AxisX.Minimum = lowerLimit;
            graph.ChartAreas[0].AxisX.Title = name;

            double k = 1.0 / (Math.Pow(upperLimit, n));

            double x = lowerLimit;

            while (x <= upperLimit)
            {
                if(incline=="Naraščajoča")
                    graph.Series[0].Points.AddXY(Math.Round(x,1), k * Math.Pow(x, n));

                else
                    graph.Series[0].Points.AddXY(Math.Round(x, 1), 1-k * Math.Pow(x, n));

                x += 0.1;
            }
        }
        private void drawLinearFunction(Chart graph)
        {
            graph.Series[0].ChartType = SeriesChartType.Line;
            graph.ChartAreas[0].AxisX.Maximum = upperLimit;
            graph.ChartAreas[0].AxisX.Minimum = lowerLimit;
            graph.ChartAreas[0].AxisX.Title = name;

         int y;
            double k;
            if (incline == "Naraščajoča")
                k= (1) / (upperLimit - lowerLimit);
            else
                k= (-1) / (upperLimit - lowerLimit);
       
            double x = lowerLimit;

            while (x <= upperLimit && k * x + n<=1)
            {
                graph.Series[0].Points.AddXY(Math.Round(x,1), k * x + n);
                x += 0.1;
                
            }
                                         
        }

        private void drawLogarithmFunction(Chart graph)
        {
            graph.Series[0].ChartType = SeriesChartType.Spline;
            graph.ChartAreas[0].AxisX.Maximum = upperLimit;
            graph.ChartAreas[0].AxisX.Minimum = lowerLimit;
            graph.ChartAreas[0].AxisX.Title = name;

            double x = lowerLimit;

            while ((x <= upperLimit) && (Math.Log(x + 1) / Math.Log(n)<=1) && (1 - Math.Log(x + 1) / Math.Log(n)<=1))
            {
                if(incline == "Naraščajoča")
                    graph.Series[0].Points.AddXY(Math.Round(x, 1), Math.Log(x+1)/Math.Log(n));

                else
                    graph.Series[0].Points.AddXY(Math.Round(x, 1), 1-Math.Log(x + 1) / Math.Log(n));

                x += 0.1;
            }
        }
    }
    }

