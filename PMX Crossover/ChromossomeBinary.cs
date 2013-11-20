using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMX_Crossover
{
    public class ChromossomeBinary
    {
        List<int> genes;

        public ChromossomeBinary(int size, Random random)
        {
            genes = new List<int>();

            for (int i = 0; i < size; i++)
            {
                genes.Add(random.Next(0,2));
            }
        }
    }
}
