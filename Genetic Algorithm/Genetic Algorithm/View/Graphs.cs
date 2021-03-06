﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Genetic_Algorithm
{
    public partial class Graphs : Form
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
        int crossoverType;
        int selectionType;
        int functionType;
        int optimizationType;
        /*Timer Process Variables*/
        bool startGA_flag = false;
        int nog_count;


        public Graphs()
        {
            InitializeComponent();
            setInitialParameters();
            setGraphSettings();
            GAPointsLI = zgcFunction.GraphPane.AddCurve("GA Points", GAPointsRPPL, Color.Blue, SymbolType.Circle);
            GAPointsLI.Line.IsVisible = false;
            EqPointsLI = zgcFunction.GraphPane.AddCurve("Equation", EqPointsRPPL, Color.LightBlue, SymbolType.Default);
            PCavgPointsLI = zgcPerformance.GraphPane.AddCurve("Xavg", PCavgPointsRPPL, Color.Red, SymbolType.Diamond);
            PCmaxPointsLI = zgcPerformance.GraphPane.AddCurve("Xmax", PCmaxPointsRPPL, Color.Blue, SymbolType.Circle);
            
        }

        /*Sets intial values*/
        private void setInitialParameters()
        {
            numPopSize.Value = 70;
            numNOG.Value = 20;
            numPC.Value = 60;
            numPM.Value = 1;
            numRangeMin.Value = 0;
            numRangeMax.Value = 63;
            numGranularity.Value = 0;
            rbRoulette.Checked = true;
            rbElitNo.Checked = true;
            rbCO2P.Checked = true;
            rbOpMin.Checked = true;
            cbFunctions.Items.Add("-|(x * Sin(Sqrt(|x|))|");
            cbFunctions.Items.Add("x * Math.Sin(x/5)");
            cbFunctions.Items.Add("((100 * Sin(x/5) + 75 * Sin(x/10)) - (50 * Sin(x/10)))" );
            cbFunctions.Items.Add("(0.9*(x^1.15)) - (x^1.05) + 50*Sin(x/10))");
            cbFunctions.Items.Add("x*0.5");
            //cbFunctions.SelectedValue = 0;
        }

        /*Sets ZedGraph Scales*/
        private void setGraphSettings()
        {
            zgcFunction.GraphPane.Title.Text = "Genetic Algorithm Plot";
            zgcFunction.GraphPane.XAxis.Title.Text = "x";
            zgcFunction.GraphPane.YAxis.Title.Text = "f(x)";

            zgcFunction.GraphPane.XAxis.Scale.Min = Convert.ToDouble(numRangeMin.Value)-20;
            zgcFunction.GraphPane.XAxis.Scale.Max = Convert.ToDouble(numRangeMax.Value)+20;
            zgcFunction.GraphPane.XAxis.Scale.MaxAuto = true;
            zgcFunction.GraphPane.XAxis.Scale.MinorStep = 1;
            zgcFunction.GraphPane.XAxis.Scale.MajorStep = 100;
            zgcFunction.GraphPane.YAxis.Scale.Min = -Convert.ToDouble(numRangeMax.Value)-20;
            zgcFunction.GraphPane.YAxis.Scale.Max = Convert.ToDouble(numRangeMax.Value)+20;
            zgcFunction.GraphPane.YAxis.Scale.MinorStep = 25;
            zgcFunction.GraphPane.YAxis.Scale.MajorStep = 100;
            

            zgcPerformance.GraphPane.Title.Text = "Performance Curve";
            zgcPerformance.GraphPane.XAxis.Title.Text = "Generation";
            zgcPerformance.GraphPane.YAxis.Title.Text = "x";

            zgcPerformance.GraphPane.XAxis.Scale.Min = 0;
            zgcPerformance.GraphPane.XAxis.Scale.Max = Convert.ToDouble(numNOG.Value);
            zgcPerformance.GraphPane.XAxis.Scale.MaxAuto = true;
            zgcPerformance.GraphPane.XAxis.Scale.MinorStep = 25;
            zgcPerformance.GraphPane.XAxis.Scale.MajorStep = 100;
            zgcPerformance.GraphPane.YAxis.Scale.Min = Convert.ToDouble(numRangeMin.Value)-20;
            zgcPerformance.GraphPane.YAxis.Scale.Max = Convert.ToDouble(numRangeMax.Value)+20;
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
            //for (double i = myGA.rangeMin; i < myGA.rangeMax; i=i+0.05)
            //{
            //    EqPointsRPPL.Add(i, Equation.set(myGA.functionType, i));
            //}
        }

        private void btStart_Click(object sender, EventArgs e)
        {

        }

        private void btGo_Click(object sender, EventArgs e)
        {
            #region radio buttons parameters
            if (rbCOUn.Checked == true)
                crossoverType = 0;
            else if (rbCO1P.Checked == true)
                crossoverType = 1;
            else if (rbCO2P.Checked == true)
                crossoverType = 2;

            if (rbRoulette.Checked == true)
                selectionType = 0;
            else if (rbTournament.Checked == true)
                selectionType = 1;

            if (rbOpMin.Checked == true)
                optimizationType = 0;
            else if (rbOpMax.Checked == true)
                optimizationType = 1;

            functionType = cbFunctions.SelectedIndex + 1;
            #endregion

            myGA = new GeneticAlgorithm(Convert.ToInt32(numPopSize.Value),
                                        Convert.ToInt32(numNOG.Value),
                                        Convert.ToInt32(numPC.Value),
                                        Convert.ToInt32(numPM.Value),
                                        selectionType,
                                        crossoverType,
                                        functionType,
                                        optimizationType,
                                        Convert.ToInt32(numRangeMin.Value),
                                        Convert.ToInt32(numRangeMax.Value),
                                        Convert.ToInt32(numGranularity.Value),
                                        random);
            setGraphFunction();
            gaTimer.Enabled = true;
            rtbInfo.Clear();
            PCavgPointsRPPL.Clear();
            PCmaxPointsRPPL.Clear();
            //PCavgPointsRPPL.Clear();

        }

        private void gaTimer_Tick(object sender, EventArgs e)
        {
            /*For the first Generation do*/
            if (startGA_flag == false)
            {
                startGA_flag = true;
                btGo.Text = "Processing";
                btGo.Enabled = false;
                
                myGA.StartsPopulation();
                myGA.SelectParents();
                myGA.Reproduction();
                nog_count++;
                graphTimer.Enabled = true;
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
                gaTimer.Enabled = false;
                graphTimer.Enabled = false;
                startGA_flag = false;
                btGo.Text = "Go";
                btGo.Enabled = true;
                nog_count = 0;
                MessageBox.Show("GA Process has reached the end!");
                btGo.Enabled = true;
            }
            
        }

        private void graphTimer_Tick(object sender, EventArgs e)
        {
            rtbInfo.AppendText(nog_count + ") Xavg: " + Math.Round(myGA.chromoValue.Average(), 2) + "\tFxavg  " + Math.Round(Equation.F3x(myGA.chromoValue.Average()),2) + "\tFitness  " + Math.Round(myGA.chromoFitness.Average(),2) + "\n");
            
            GAPointsRPPL.Clear();
            for (int i = 0; i < myGA.populationSize; i++)
            {
                GAPointsRPPL.Add(myGA.chromoValue[i], Equation.set(myGA.functionType,myGA.chromoValue[i]));
            }

            PCavgPointsRPPL.Add(nog_count, myGA.chromoValue.Average());
            PCmaxPointsRPPL.Add(nog_count, myGA.chromoValue.Max());

            //PCavgPointsRPPL.Add(nog_count, myGA.chromoFitness.Average());
            //PCmaxPointsRPPL.Add(nog_count, myGA.chromoFitness.Max());

            zgcFunction.Invalidate();
            zgcPerformance.Invalidate();
        }

        
    }
}
