using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public static class Equation
    {
        public static double set(int functionType, double x)
        {
            double y;
            switch (functionType)
            {
                case 1:
                    {
                        y = F1x(x);
                    }
                    break;

                case 2:
                    {
                        y = F2x(x);
                    }
                    break;

                default:
                    {
                        y = F1x(x);
                    }
                    break;
            }
            return y;
        }

        public static double F1x(double x)
        {
            return (-(Math.Abs(x * Math.Sin(Math.Sqrt(Math.Abs(x))))));
        }

        public static double F2x(double x)
        {
            return (x * Math.Sin(x/5));
        }
    }
}
