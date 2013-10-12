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

namespace Genetic_Algorithm
{
    public partial class User_Inputs : Form
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


        public User_Inputs()
        {
            InitializeComponent();         
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
            gaTimer.Enabled = true;

        }

        private void gaTimer_Tick(object sender, EventArgs e)
        {
            
        }

        private void graphTimer_Tick(object sender, EventArgs e)
        {

        }
 
    }
}
