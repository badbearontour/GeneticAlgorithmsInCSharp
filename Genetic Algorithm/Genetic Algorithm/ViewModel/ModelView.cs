using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public class ViewModel
    {
        private readonly Random random = new Random();
        public GeneticAlgorithm myGA;

        public ViewModel(int _populationsize, int _numberGenerations, int _probabilityCrossover, int _probabilityMutation, int _rangeMin, int _rangeMax, int _granularity)
        {

        } 
    }
}
