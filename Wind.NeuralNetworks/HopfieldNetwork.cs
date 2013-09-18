using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine
{
    class HopfieldNetwork
    {
        private Matrix weightMatrix;

        public Matrix LayerMatrix
        {
            get
            {
                return this.weightMatrix;
            }
        }

        public int Size
        {
            get
            {
                return this.weightMatrix.Rows;
            }
        }

        public HopfieldNetwork(int neuronsCount)
        {
            this.weightMatrix = new Matrix(neuronsCount, neuronsCount);
        }

        public bool[] Present(bool[] pattern)
        {
            bool[] output = new bool[pattern.Length];

            Matrix inputRow = Matrix.CreateRowMatrix(BiPolarUtil.BipolarToDouble(pattern));

            for (int i = 0; i < pattern.Length; ++i)
            {
                Matrix weightColumn = this.weightMatrix.GetCol(i);
                weightColumn = MatrixMath.Transpose(weightColumn);

                double dotProduct = MatrixMath.DotProduct(inputRow, weightColumn);
                output[i] = ConvertOutputToBool(dotProduct);
            }

            return output;
        }

        public void Train(bool[] pattern)
        {
            if (pattern.Length != this.Size)
            {
                throw new ArgumentException("Impossible to train network of "
                    + this.Size + " size with pattern of " + pattern.Length + " size.");
            }

            Matrix contributionRow = Matrix.CreateRowMatrix(BiPolarUtil.BipolarToDouble(pattern));
            Matrix contributionCol = MatrixMath.Transpose(contributionRow);
            Matrix contributionMatrix = MatrixMath.Multiply(contributionCol, contributionRow);
            contributionMatrix = MatrixMath.Subtract(contributionMatrix,
                MatrixMath.Identity(contributionMatrix.Rows));


            this.weightMatrix = MatrixMath.Add(weightMatrix, contributionMatrix);
        }

        private bool ConvertOutputToBool(double output)
        {
            return output > 0 ? true : false;
        }

    }
}
