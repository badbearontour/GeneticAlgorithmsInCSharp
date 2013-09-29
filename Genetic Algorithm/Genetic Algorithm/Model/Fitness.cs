using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetic_Algorithm
{
    public static class Fitness
    {
        public static double set(int functionType, int optimizationType, double x)
        {
            double y;
            #region switch cases
            switch (optimizationType)
            {
                case 0:
                {
                    switch (functionType)
                    {
                        case 1:
                        {
                            y = F1xMin(x);
                        }
                        break;

                        case 2:
                        {
                            y = F2xMin(x);
                        }
                        break;

                        default:
                        {
                            y = F1xMin(x);
                        }
                        break;
                    }
                }
                break;

                case 1:
                {
                    switch (functionType)
                    {
                        case 1:
                        {
                            y = F1xMax(x);
                        }
                        break;

                        case 2:
                        {
                            y = F2xMax(x);
                        }
                        break;

                        default:
                        {
                            y = F1xMax(x);
                        }
                        break;
                    }
                }
                break;

                default:
                {
                    switch (functionType)
                    {
                        case 1:
                        {
                            y = F1xMin(x);
                        }
                        break;

                        case 2:
                        {
                            y = F2xMin(x);
                        }
                        break;

                        default:
                        {
                            y = F1xMin(x);
                        }
                        break;
                    }
                }
                break;
            }
            #endregion
            return y;
        }


        public static double F1xMin(double x)
        {
            return (Equation.F1x(x));
        }
        public static double F1xMax(double x)
        {
            return (-Equation.F1x(x)+1000);
        }

        public static double F2xMin(double x)
        {
            return (-Equation.F2x(x)+1000);
        }

        public static double F2xMax(double x)
        {
            return (Equation.F2x(x));
        }

        
    }
}
