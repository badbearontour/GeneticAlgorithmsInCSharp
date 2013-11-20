using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMX_Crossover
{
    public class Gene
    {
        public object value = new object();
        int[] op_i = { 0, 1 };
        string[] op_s = { "0", "1" };

        public Gene(string type, Random rand)
        {
            
        }

        public Gene(int i, Random rand)
        {
            value = op_i[rand.Next(0, op_i.Count())];
        }



    }
}
