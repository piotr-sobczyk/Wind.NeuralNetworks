using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine.ActivationFunctions
{
    static class HyperbolicTangent
    {
        static public double GetValue(double x)
        {
            double value = (Math.Exp(2 * x) - 1) 
                / (Math.Exp(2 * x) + 1);
            return value;
        }
        static public double GetDerivative(double x)
        {
            double value = 1 - Math.Pow(GetValue(x), 2);
            return value;
        }
    }
}
