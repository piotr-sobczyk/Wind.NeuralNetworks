using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine.Feedforward
{
    class Layer
    {
        double[] neurons;

        public double this[int index]
        {
            get
            {
                ValidateCoords(index);
                return this.neurons[index];
            }
            set
            {
                ValidateCoords(index);
                this.neurons[index] = value;
            }
        }

        public Layer(int size)
        {
            this.neurons = new double[size];
        }
        public Layer(double[] neuronArray)
        {
            this.neurons = new double[neuronArray.Length];

            for (int i = 0; i < neuronArray.Length; ++i)
            {
                this.neurons[i] = neuronArray[i];
            }
        }

        private void ValidateCoords(int index)
        {
            if (index >= neurons.Length)
            {
                throw new ArgumentException("Index out of layer bounds. Largest index avaliable: "
                    + (this.neurons.Length - 1));
            }
        }
    }
}
