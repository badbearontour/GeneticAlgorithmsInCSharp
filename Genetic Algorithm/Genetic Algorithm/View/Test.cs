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
    public partial class Test : Form
    {
        Random _random = new Random();
        List<string> chromoP = new List<string>();
        List<string> chromoC = new List<string>();
        bool initflag = false;

        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox2.Clear();
            chromoP.Clear();
            chromoC.Clear();
            initflag = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (initflag == true)
            {
                chromoC = Crossover.TwoPoints(chromoP, 50, _random);
                richTextBox1.Clear();
                richTextBox2.Clear();
                for (int i = 0; i < chromoP.Count(); i++)
                {
                    richTextBox1.AppendText(chromoP[i] + "\n");
                    richTextBox2.AppendText(chromoC[i] + "\n");
                }
                chromoP = chromoC;
            }
            else
            {
                chromoP = Chromossome.Creates(6, 0, 63, 0, _random);
                initflag = true;
            }
            
        }
    }
}
