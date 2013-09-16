using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine.ErrorUtility
{
    class ErrorCalculation
    {
        private double globalError;
        private int setSize;

        public double GetRMS()
        {
            double error = Math.Sqrt(this.globalError /
                this.setSize);
            return error;
        }

        public void Reset()
        {
            this.globalError = 0.0f;
            this.setSize = 0;
        }

        public void UpdateError(double[] actual, double[] ideal)
        {
            for (int i = 0; i < actual.Length; ++i)
            {
                double delta = ideal[i] - actual[i];
            }
        }
    }
}
