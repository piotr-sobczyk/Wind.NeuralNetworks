using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine
{
    class BiPolarUtil
    {
        public static double BipolarToDouble(bool bipolar)
        {
            if (bipolar == true)
            {
                return 1.0f;
            }

            return -1.0f;
        }
        public static double[] BipolarToDouble(bool[] bipolarVec)
        {
            double[] result = new double[bipolarVec.Length];
            
            for(int i = 0; i < result.Length; ++i)
            {
                result[i] = BipolarToDouble(bipolarVec[i]);
            }
            
            return result;
        }
        public static double[,] BipolarToDouble(bool[,] bipolarMatrix)
        {
            double[,] result = new double[bipolarMatrix.GetUpperBound(0),
                bipolarMatrix.GetUpperBound(1)];

            for (int i = 0; i < bipolarMatrix.GetUpperBound(0); ++i)
            {
                for (int j = 0; j < bipolarMatrix.GetUpperBound(1); ++j)
                {
                    result[i, j] = BipolarToDouble(bipolarMatrix[i, j]);
                }
            }

            return result;
        }

        public static bool DoubleToBipolar(double value) 
        {
            if(value > 0.0f)
            {
                return true;
            }

            return false;
        }
        public static bool[] DoubleToBipolar(double[] valueVec)
        {
            bool[] result = new bool[valueVec.Length];

            for (int i = 0; i < valueVec.Length; ++i)
            {
                result[i] = DoubleToBipolar(valueVec[i]);
            }

            return result;
        }
        public static bool[,] DoubleToBipolar(double[,] valueMatrix)
        {
            bool[,] result = new bool[valueMatrix.GetUpperBound(0),
                valueMatrix.GetUpperBound(1)];

            for (int i = 0; i < valueMatrix.GetUpperBound(0); ++i)
            {
                for (int j = 0; j < valueMatrix.GetUpperBound(1); ++j)
                {
                    result[i, j] = DoubleToBipolar(valueMatrix[i, j]);
                }
            }

            return result;
        }

        public static double NormalizeBinary(double binaryValue)
        {
            if (binaryValue > 0.0f)
            {
                return 1.0f;
            }

            return 0.0f;
        }
        public static double ToBinary(double bipolarBinaryValue) 
        {
            double result = (bipolarBinaryValue + 1) / 2.0f;
            
            return result;
        }
        public static double ToBipolar(double binaryValue)
        {
            double result = (NormalizeBinary(binaryValue) * 2) - 1;

            return result;
        }
        public static double ToNormalizedBinary(double bipolarBinaryValue)
        {
            double result = ToNormalizedBinary(ToBinary(bipolarBinaryValue));
            
            return result;
        }
    }
}
