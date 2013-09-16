using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine
{
    class MatrixMath
    {
        private static void AreSameSize(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows ||
                firstMatrix.Cols != secondMatrix.Cols)
            {
                throw new ArgumentException("Given matrixes aren't even on size." +
                    "\nfirstMatrix rows = " + firstMatrix.Rows +
                    "\nfirstMatrix cols = " + firstMatrix.Cols + 
                    "\nSecondMatrix rows = " + secondMatrix.Rows + 
                    "\nSecondMatrix cols = " + secondMatrix.Cols);
            }
        }
        private static void SameRowLength(Matrix firstMatrix, Matrix secondMatrix)
        {
            if (firstMatrix.Rows != secondMatrix.Rows)
            {
                throw new ArgumentException("Given matrixes doesn't have the same amount of rows." + 
                    " Can not multiply matrices.");
            }
        }
        
        public static Matrix Add(Matrix firstAddend, Matrix secondAddend)
        {
            AreSameSize(firstAddend, secondAddend);

            double[,] result = new double[firstAddend.Rows, firstAddend.Cols];

            for (int i = 0; i < firstAddend.Rows; ++i)
            {
                for (int j = 0; j < firstAddend.Cols; ++j)
                {
                    result[i, j] = firstAddend[i, j] + secondAddend[i, j];
                }
            }

            return new Matrix(result);
        }

        public static Matrix Subtract(Matrix minuend, Matrix subtrahend)
        {
            AreSameSize(minuend, subtrahend);

            double[,] result = new double[minuend.Rows, minuend.Cols];

            for (int i = 0; i < minuend.Rows; ++i)
            {
                for (int j = 0; j < minuend.Cols; ++j)
                {
                    result[i, j] = minuend[i, j] - subtrahend[i, j];
                }
            }

            return new Matrix(result);
        }

        public static Matrix Multiply(Matrix multiplier, Matrix multiplicand)
        {
            //SameRowLength(multiplier, multiplicand);

            double[,] result = new double[multiplier.Rows, multiplicand.Cols];

            for (int i = 0; i < multiplier.Rows; ++i)
            {
                for (int j = 0; j < multiplicand.Cols; ++j)
                {
                    for (int k = 0; k < multiplicand.Rows; ++k)
                    {
                        result[i, j] += multiplier[i, k] * multiplicand[k, j];
                    }
                }
            }

            return new Matrix(result);
        }
        public static Matrix Multiply(Matrix matrix, double factor)
        {
            double[,] result = new double[matrix.Rows, matrix.Cols];

            for (int i = 0; i < matrix.Rows; ++i)
            {
                for (int j = 0; j < matrix.Cols; ++j)
                {
                    result[i, j] = matrix[i, j] * factor;
                }
            }

            return new Matrix(result);
        }

        public static Matrix Divide(Matrix matrix, double divisor)
        {
            double[,] result = new double[matrix.Rows, matrix.Cols];

            for (int i = 0; i < matrix.Rows; ++i)
            {
                for (int j = 0; j < matrix.Cols; ++j)
                {
                    result[i, j] = matrix[i, j] / divisor;
                }
            }

            return new Matrix(result);
        }

        public static double DotProduct(Matrix firstVector, Matrix secondVector)
        {
            if (!(firstVector.IsVector() && secondVector.IsVector()))
            {
                throw new ArgumentException("Both matrixes have to be vectors.");
            }

            double[] firstArray = firstVector.ToPackedArray();
            double[] secondArray = secondVector.ToPackedArray();

            if (firstArray.Length != secondArray.Length)
            {
                throw new ArgumentException("Both vectors have to be the same length.");
            }

            double result = 0.0f;

            for (int i = 0; i < firstArray.Length; ++i)
            {
                result += firstArray[i] * secondArray[i];
            }

            return result;
        }

        public static void Copy(Matrix source, Matrix target)
        {
            AreSameSize(source, target);
            
            for (int i = 0; i < source.Rows; ++i)
            {
                for (int j = 0; j < source.Cols; ++j)
                {
                    target[i, j] = source[i, j];
                }
            }
        }

        public static Matrix DeleteCol(Matrix matrix, int index)
        {
            if (index >= matrix.Cols)
            {
                throw new ArgumentException("Out of bound index.");
            }

            double[,] result = new double[matrix.Rows, matrix.Cols - 1];

            for (int i = 0; i < matrix.Rows; ++i)
            {
                for (int j = 0, k = 0; j < matrix.Cols; ++j)
                {
                    if (!(j == index))
                    {
                        result[i, k] = matrix[i, j];
                        ++k;
                    }
                }
            }

            return new Matrix(result);
        }
        public static Matrix DeleteRow(Matrix matrix, int index)
        {
            if (index >= matrix.Rows)
            {
                throw new ArgumentException("Out of bounds index.");
            }

            double[,] result = new double[matrix.Rows - 1, matrix.Cols];

            for (int i = 0, k = 0; i < matrix.Rows; ++i)
            {
                if (!(i == index))
                {
                    for (int j = 0; j < matrix.Cols; ++j)
                    {
                        result[k, j] = matrix[i, j];
                    }

                    ++k;
                }
            }

            return new Matrix(result);
        }

        public static Matrix Transpose(Matrix matrix)
        {
            double[,] result = new double[matrix.Cols, matrix.Rows];

            for (int i = 0; i < matrix.Rows; ++i)
            {
                for (int j = 0; j < matrix.Cols; ++j)
                {
                    result[j, i] = matrix[i, j];
                }
            }

            return new Matrix(result);
        }

        public static double VectorLength(Matrix vector)
        {
            if (!vector.IsVector())
            {
                throw new ArgumentException("Given matrix isn't a vector.");
            }

            double[] array = vector.ToPackedArray();
            double result = 0.0;

            for (int i = 0; i < array.Length; ++i)
            {
                result += Math.Pow(array[i], 2);
            }

            result = Math.Sqrt(result);
            
            return result;
        }

        public static Matrix Identity(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Can not create a matrix with zero or less size.");
            }
            
            double[,] result = new double[size, size];

            for (int i = 0; i < size; ++i)
            {
                for (int j = 0; j < size; ++j)
                {
                    if (i == j)
                    {
                        result[i, j] = 1.0f;
                    }
                    else
                    {
                        result[i, j] = 0.0f;
                    }
                }
            }

            return new Matrix(result);
        }
    }
}
