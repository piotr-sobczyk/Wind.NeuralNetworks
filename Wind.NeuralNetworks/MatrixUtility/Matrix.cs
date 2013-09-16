using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace neural_computing_machine
{
    [Serializable]
    class Matrix
    {
        private double[,] matrix;

        public double this[int row, int col]
        {
            get
            {
                ValidateCoords(row, col);
                return this.matrix[row, col];
            }
            set
            {
                ValidateCoords(row, col);
                if (double.IsInfinity(value) || double.IsNaN(value))
                {
                    throw new ArgumentException("Invalid input value.");
                }

                this.matrix[row, col] = value;
            }
        }
        public int Rows
        {
            get
            {
                return this.matrix.GetUpperBound(0) + 1;
            }
        }
        public int Cols
        {
            get
            {
                return this.matrix.GetUpperBound(1) + 1;
            }
        }
        public int Size
        {
            get
            {
                return this.Cols * this.Rows;
            }
        }

        public Matrix(int rows, int columns)
        {
            this.matrix = new double[rows, columns];
        }
        public Matrix(bool[,] booleanSourceMatrix)
        {
            this.matrix = new double[booleanSourceMatrix.GetUpperBound(0) + 1,
                booleanSourceMatrix.GetUpperBound(1) + 1];

            for (int i = 0; i < matrix.GetUpperBound(0); ++i)
            {
                for (int j = 0; j < matrix.GetUpperBound(1); ++j)
                {
                    if (booleanSourceMatrix[i, j])
                    {
                        this.matrix[i, j] = 1;
                    }
                    else
                    {
                        this.matrix[i, j] = -1;
                    }
                }
            }
        }
        public Matrix(double[,] floatSourceMatrix)
        {
            this.matrix = new double[floatSourceMatrix.GetUpperBound(0) + 1,
                floatSourceMatrix.GetUpperBound(1) + 1];

            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Cols; ++j)
                {
                    this.matrix[i, j] = floatSourceMatrix[i, j];
                }
            }
        }

        public Matrix GetCol(int index)
        {
            if (index >= this.Cols)
            {
                throw new ArgumentException("Given index has an invalid value.");
            }

            double[,] matrix = new double[this.Rows, 1];

            for (int i = 0; i < this.Rows; ++i)
            {
                matrix[i, 0] = this.matrix[i, index];
            }

            return new Matrix(matrix);
        }
        public Matrix GetRow(int index)
        {
            if (index >= this.Rows)
            {
                throw new ArgumentException("Given index has an invalid value.");
            }

            double[,] matrix = new double[1, this.Cols];

            for (int i = 0; i < this.Cols; ++i)
            {
                matrix[0, i] = this.matrix[index, i];
            }

            return new Matrix(matrix);
        }

        public static Matrix CreateColumnMatrix(double[] input)
        {
            double[,] matrix = new double[input.Length, 1];

            for (int i = 0; i < input.Length; ++i)
            {
                matrix[i, 0] = input[i];
            }
            
            return new Matrix(matrix);
        }
        public static Matrix CreateRowMatrix(double[] input)
        {
            double[,] matrix = new double[1, input.Length];

            for (int i = 0; i < input.Length; ++i)
            {
                matrix[0, i] = input[i];
            }
            
            return new Matrix(matrix);
        }

        public void Add(int row, int col, double value)
        {
            this[row, col] += value;
        }

        public Matrix Clone()
        {
            return new Matrix(this.matrix);
        }
        public void Clear()
        {
            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Cols; ++j)
                {
                    this.matrix[i, j] = 0;
                }
            }
        }

        public bool Equals(Matrix matrix)
        {
            return Equals(matrix, 10);
        }
        public bool Equals(Matrix matrix, double precision)
        {
            if (!IsPrecisionValid(precision))
            {
                throw new ArgumentException("Given precision can not be used.");
            }

            precision = (int)Math.Pow(10.0, precision);
            
            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Cols; ++j)
                {
                    long sourcePrec = (long)(matrix[i, j] * precision);
                    long matrixPrec = (long)(this[i, j] * precision);

                    if (sourcePrec != matrixPrec)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsVector()
        {
            bool isVector = (this.Rows == 1 || this.Cols == 1);
            return isVector;
        }
        public bool IsZero()
        {
            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Cols; ++j)
                {
                    if (this[i, j] != 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public void Randomize(double min, double max)
        {
            Random rand = new Random();

            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Rows; ++j)
                {
                    this[i, j] = min + (rand.NextDouble() * (max - min));
                }
            }
        }

        public double Sum()
        {
            double result = 0.0f;

            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Cols; ++j)
                {
                    result += this[i, j];
                }
            }

            return result;
        }

        public double[] ToPackedArray()
        {
            double[] resultArray = new double[this.Size];
            int arrayIndex = 0;

            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Cols; ++j)
                {
                    resultArray[arrayIndex] = this[i, j];
                    ++arrayIndex;
                }
            }

            return resultArray;
        }
        public void FromPackedArray(double[] array)
        {
            int arrayIndex = 0;

            for (int i = 0; i < this.Rows; ++i)
            {
                for (int j = 0; j < this.Cols; ++j)
                {
                    this[i, j] = array[arrayIndex];
                    arrayIndex++;
                }
            }
        }

        public bool IsPrecisionValid(double precision)
        {
            if (precision < 0)
            {
                return false;
            }

            double precisionTest = Math.Pow(10.0, precision);
            if (double.IsInfinity(precisionTest) || precisionTest > long.MaxValue)
            {
                return false;
            }

            return true;
        }
        public void ValidateCoords(int row, int col)
        {
            if (row >= this.Rows || row < 0)
            {
                throw new ArgumentException("Invalid row index; range: " + (this.Rows - 1));
            }

            if (col >= this.Cols || col < 0)
            {
                throw new ArgumentException("Invalid column index; range: " + (this.Cols - 1));
            }
        }
    }
}
