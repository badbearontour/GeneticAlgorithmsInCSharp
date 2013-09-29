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
        List<string> offspring = new List<string>();
        List<double> offsValue = new List<double>();
        List<double> offFit = new List<double>();
        List<int> pointer = new List<int>();
        string garbage;
        int point;

        public Test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            garbage = "011010";
            richTextBox1.AppendText(garbage + "\n");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
           //if ((_random.NextDouble() * 100) < _probabilityMutation)
            //{
                point = _random.Next(0, garbage.Length);
                richTextBox1.AppendText(point + "\n");
                if (garbage[point] == '0')
                    garbage = garbage.Substring(0, point) + "1" + garbage.Substring(point + 1, garbage.Length - point - 1);
                else
                    garbage = garbage.Substring(0, point) + "0" + garbage.Substring(point + 1, garbage.Length - point - 1);
                richTextBox1.AppendText(garbage + "\n");
            //}
        }
    }
}
