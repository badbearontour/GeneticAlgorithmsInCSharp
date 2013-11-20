using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using Genetic_Algorithm;

namespace Basic_GA_1
{
    public partial class Graphic_View : Form
    {
        /*GUI Variables Declared -> Related to ZedGraph*/
        RollingPointPairList GAPointsRPPL = new RollingPointPairList(1000); //GA Population List Points
        LineItem GAPointsLI;
        RollingPointPairList EqPointsRPPL = new RollingPointPairList(10000); //Equation Function List Points
        LineItem EqPointsLI;
        RollingPointPairList PCavgPointsRPPL = new RollingPointPairList(1000); //Performance Curve Population List Points
        LineItem PCavgPointsLI;
        RollingPointPairList PCmaxPointsRPPL = new RollingPointPairList(1000); //Performance Curve Population List Points
        LineItem PCmaxPointsLI;

        Random random = new Random();
        GeneticAlgorithm myGA;

        /*Timer Process Variables*/
        bool startGA_flag = false;
        int nog_count;

        /*Constructor*/
        public Graphic_View()
        {
            InitializeComponent();
        }

        /*Overrided Constructor*/
        public Graphic_View(int ps, int ng, int pc, int pm, int rmin, int rmax, int gran, int selec_op, int cross_op, int optim_op)
        {
            InitializeComponent();
            myGA = new GeneticAlgorithm(rmin, rmax, gran, ps, ng, pc, pm, selec_op, cross_op, 0, optim_op, random);

            setGraphSettings();
            GAPointsLI = zgcFunction.GraphPane.AddCurve("GA Points", GAPointsRPPL, Color.Blue, SymbolType.Circle);
            GAPointsLI.Line.IsVisible = false;
            EqPointsLI = zgcFunction.GraphPane.AddCurve("Equation", EqPointsRPPL, Color.LightBlue, SymbolType.Default);
            PCavgPointsLI = zgcPerformance.GraphPane.AddCurve("Xavg", PCavgPointsRPPL, Color.Red, SymbolType.Diamond);
            PCmaxPointsLI = zgcPerformance.GraphPane.AddCurve("Xmax", PCmaxPointsRPPL, Color.Blue, SymbolType.Circle);
            
            setGraphFunction();
            GenAlgTimer.Enabled = true;
            PCavgPointsRPPL.Clear();
            PCmaxPointsRPPL.Clear();
        }

        /*Sets ZedGraph Scales*/
        private void setGraphSettings()
        {
            zgcFunction.GraphPane.Title.Text = "Genetic Algorithm Plot";
            zgcFunction.GraphPane.XAxis.Title.Text = "x";
            zgcFunction.GraphPane.YAxis.Title.Text = "f(x)";

            zgcFunction.GraphPane.XAxis.Scale.Min = Convert.ToDouble(myGA.rangeMin) - 20;
            zgcFunction.GraphPane.XAxis.Scale.Max = Convert.ToDouble(myGA.rangeMax) + 20;
            zgcFunction.GraphPane.XAxis.Scale.MaxAuto = true;
            zgcFunction.GraphPane.XAxis.Scale.MinorStep = 1;
            zgcFunction.GraphPane.XAxis.Scale.MajorStep = 100;
            zgcFunction.GraphPane.YAxis.Scale.Min = - Convert.ToDouble(myGA.rangeMax) - 20;
            zgcFunction.GraphPane.YAxis.Scale.Max = Convert.ToDouble(myGA.rangeMax) + 20;
            zgcFunction.GraphPane.YAxis.Scale.MinorStep = 25;
            zgcFunction.GraphPane.YAxis.Scale.MajorStep = 100;


            zgcPerformance.GraphPane.Title.Text = "Performance Curve";
            zgcPerformance.GraphPane.XAxis.Title.Text = "Generation";
            zgcPerformance.GraphPane.YAxis.Title.Text = "x";

            zgcPerformance.GraphPane.XAxis.Scale.Min = 0;
            zgcPerformance.GraphPane.XAxis.Scale.Max = Convert.ToDouble(myGA.numberGenerations);
            zgcPerformance.GraphPane.XAxis.Scale.MaxAuto = true;
            zgcPerformance.GraphPane.XAxis.Scale.MinorStep = 25;
            zgcPerformance.GraphPane.XAxis.Scale.MajorStep = 100;
            zgcPerformance.GraphPane.YAxis.Scale.Min = Convert.ToDouble(myGA.rangeMin) - 20;
            zgcPerformance.GraphPane.YAxis.Scale.Max = Convert.ToDouble(myGA.rangeMax) + 20;
            zgcPerformance.GraphPane.YAxis.Scale.MinorStep = 25;
            zgcPerformance.GraphPane.YAxis.Scale.MajorStep = 100;

        }

        /*Creates the curve for the equation type 1*/
        public void setGraphFunction()
        {
            setGraphSettings();
            EqPointsRPPL.Clear();
            double i = myGA.rangeMin;
            double j;
            while (i < myGA.rangeMax)
            {
                j = Equation.set(myGA.functionType, i);
                EqPointsRPPL.Add(i, j);

                i = i + 0.05;
            }
            zgcFunction.Invalidate();
        }

        private void GenAlgTimer_Tick(object sender, EventArgs e)
        {
            /*For the first Generation do*/
            if (startGA_flag == false)
            {
                startGA_flag = true;

                myGA.StartsPopulation();
                myGA.SelectParents();
                myGA.Reproduction();
                nog_count++;
                UpdateGraphTimer.Enabled = true;
            }
            /*For the following Generation do*/
            else
            {
                myGA.SelectParents();
                myGA.Reproduction();
                nog_count++;
            }

            /*After reaching the number of generations value stops the GA process and the Graph Update Process*/
            if (nog_count >= myGA.numberGenerations)
            {
                GenAlgTimer.Enabled = false;
                UpdateGraphTimer.Enabled = false;
                startGA_flag = false;
                nog_count = 0;
                MessageBox.Show("GA Process has reached the end!");

            }
        }

        private void UpdateGraphTimer_Tick(object sender, EventArgs e)
        {
            GAPointsRPPL.Clear();
            for (int i = 0; i < myGA.populationSize; i++)
            {
                GAPointsRPPL.Add(myGA.chromoValue[i], Equation.set(myGA.functionType, myGA.chromoValue[i]));
            }

            PCavgPointsRPPL.Add(nog_count, myGA.chromoValue.Average());
            PCmaxPointsRPPL.Add(nog_count, myGA.chromoValue.Max());

            zgcFunction.Invalidate();
            zgcPerformance.Invalidate();
        }


    }
}
