using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine.ActivationFunctions
{
    static class Sigmoid
    {
        static public double GetValue(double x)
        {
            double value = 1 / (1 + Math.Exp(-x));
            return value;
        }
        static public double GetDerivative(double x)
        {
            double value = GetValue(x) * (1 - GetValue(x));
            return value;
        }
    }
}
