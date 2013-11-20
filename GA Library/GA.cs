using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_Library
{
    public class GA
    {
        /*GA Parameters Variables*/
        public int popsize, numgenerations;
        private double probcrossover, probmutation;
        private int rangemin, rangemax, granularity;
        private int elitism_counter;

        /*GA Lists Variables*/
        public List<List<string>> population_values;
        public List<double> population_fitness;

        public GA()
        {

        }
    }
}
