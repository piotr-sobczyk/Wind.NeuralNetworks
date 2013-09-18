using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine.Feedforward
{
    class Network
    {
        List<Layer> layers;
        
        public Network()
        {
            this.layers = new List<Layer>();
        }

        public void AddLayer(Layer layer)
        {
            this.layers.Add(layer);
        }
    }
}
