using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RizerMatrix
{
    class Matrix
    {
        double[,] matrix;

        public Matrix(int rows, int cols)
        {
            matrix = new double[rows, cols];
        }

        public int Rows
        {
            get
            {
                return matrix.GetLength(0);
            }
        }

        public int Cols
        {
            get
            {
                return matrix.GetLength(1);
            }
        }

        public double this[int i, int j]
        {
            get
            {
                return matrix[i, j];
            }
            set
            {
                matrix[i, j] = value;
            }
        }
        
        public Matrix Add(Matrix x)
        {
            Matrix y = new Matrix(x.Rows, x.Cols);

            for (int i = 0; i < x.Rows; i++)
            {
                for (int j = 0; j <x.Cols; j++)
                {
                    y[i, j] = this[i, j] + x[i, j];
                }
            }

            return y;
        }

        public Matrix Subtract(Matrix x)
        {
            Matrix y = new Matrix(x.Rows, x.Cols);

            for (int i = 0; i < x.Rows; i++)
            {
                for (int j = 0; j < x.Cols; j++)
                {
                    y[i, j] = this[i, j] - x[i, j];
                }
            }

            return y;
        }

        public Matrix Multiply(Matrix x)
        {
            Matrix y = new Matrix(x.Rows, this.Cols);

            for (int i = 0; i < x.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    for (int k = 0; k < x.Cols; k++)
                    {
                        y[i, j] += x[i, k] * this[k, j];
                        Math.Round(y[i, j], 1);
                    }
                }
            }

            return y;
        }

        public bool ColsEqual(Matrix x)
        {
            return x.Cols == this.Cols;
        }

        public bool RowsEqual(Matrix x)
        {
            return x.Rows == this.Rows;
        }

        public bool DimsEqual(Matrix x)
        {
            return (x.Rows == this.Rows) && (x.Cols == this.Cols);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;

            Matrix x = (Matrix)obj;

            if (!this.RowsEqual(x) ||!this.ColsEqual(x))
                return false;

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (x[i, j] != this[i, j])
                        return false;
                }
            }

            return true;
        }

        public double Sum()
        {
            double x = 0;

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    x += this[i, j];
                }
            }

            return x;
        }

        public override int GetHashCode()
        {
            return Sum().GetHashCode();
        }

        public void MakeId()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (i == j)
                        this[i, j] = 1.0;
                    else
                        this[i, j] = 0.0;
                }
            }
        }

        public Matrix Clone()
        {
            Matrix x = new Matrix(this.Rows, this.Cols);

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    x[i, j] = this[i, j];
                }
            }

            return x;
        }

        public void Copy(Matrix x)
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    this[i, j] = x[i, j];
                }
            }
        }

        public void PopulateRand()
        {
            Random r = new Random();

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    this[i, j] = r.Next(10);
                }
            }
        }

        public void PopulateOrd()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    this[i, j] = i+j;
                }
            }
        }

        public static bool operator == (Matrix a, Matrix b)
        {
            if (Equals(a, null))
                if (Equals(b, null))
                    return true;
                else
                    return false;
            else
                return a.Equals(b);
        }

        public static bool operator != (Matrix a, Matrix b)
        {
            return !(a == b);
        }

        public static Matrix operator * (Matrix a, Matrix b)
        {
            if (Equals(a, null) || Equals(b, null))
                throw new ArgumentNullException("One or both vectors are null.");
            if (a.Rows != b.Rows || a.Cols != b.Cols)
                throw new ArgumentException("Dimensions do not match");
            return a.Multiply(b);
        }

        public static Matrix operator + (Matrix a, Matrix b)
        {
            if (Equals(a, null) || Equals(b, null))
                throw new ArgumentNullException("One or both vectors are null.");
            if (a.Rows != b.Rows || a.Cols != b.Cols)
                throw new ArgumentException("Dimensions do not match");
            return a.Add(b);
        }

        public static Matrix operator - (Matrix a, Matrix b)
        {
            if (Equals(a, null) || Equals(b, null))
                throw new ArgumentNullException("One or both vectors are null.");
            if (a.Rows != b.Rows || a.Cols != b.Cols)
                throw new ArgumentException("Dimensions do not match");
            return a.Subtract(b);
        }

        public override string ToString()
        {
            string s = "";

            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    s += this[i, j].ToString() + " ";
                }

                s += "\r\n";
            }

            return s;
        }
    }
}
