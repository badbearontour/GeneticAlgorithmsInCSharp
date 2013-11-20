using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMX_Crossover
{
    public class Chromossome
    {
        public List<object> genes;
        public int size;
        public object[] Uchromossomes = {0, 1, 9};

        public Chromossome(int _size, Random _random)
        {
            genes = new List<object>();
            for (int i = 0; i < _size; i++)
            {
                genes.Add(Uchromossomes[_random.Next(0,Uchromossomes.Count())]);
            }
        }

    }
}
