using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Genetic_Algorithm
{
    public partial class User_Inputs : Form
    {
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
        }
    }
}
