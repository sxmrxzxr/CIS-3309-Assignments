using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RizerMatrix
{
    public partial class frmMain : Form
    {
        public double[,] A;
        public double[,] B;
        public double[,] C;

        Random ran = new Random();

        public frmMain()
        {
            InitializeComponent();
            rbnMultiply.Checked = true;
        }

        private double[,] MakeMatrix(int r, int c)
        {
            double[,] x = new double[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    x[i, j] = Math.Round(ran.NextDouble() * 10.0, 1);
                }
            }

            return x;
        }

        private void MakeIdentityMatrix(int r, int c)
        {
            B = new double[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == j)
                    {
                        B[i, j] = 1.0;
                    }
                    else
                    {
                        B[i, j] = 0.0;
                    }
                }
            }
        }

        private string MatrixToString(double[,] x)
        {
            string s = "";
            
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    s += x[i, j].ToString() + "\t";
                }
                s += "\r\n";
            }
            
            return s;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMakeMatrixA_Click(object sender, EventArgs e)
        {            
            if (IsValidData(txtMatrixARows) && IsValidData(txtMatrixACols))
            {
                A = MakeMatrix(Convert.ToInt32(txtMatrixARows.Text), Convert.ToInt32(txtMatrixACols.Text));
                txtMatrixA.Text = MatrixToString(A);
            }
        }

        private void btnMakeMatrixB_Click(object sender, EventArgs e)
        {
            if (IsValidData(txtMatrixBRows) && IsValidData(txtMatrixBCols))
            {
                B = MakeMatrix(Convert.ToInt32(txtMatrixBRows.Text), Convert.ToInt32(txtMatrixBCols.Text));
                txtMatrixB.Text = MatrixToString(B);
            }
        }

        private bool IsValidData(TextBox t)
        {
            int d = 0;

            if (Int32.TryParse(t.Text, out d))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Please enter a valid integer for the text box");
                return false;
            }
        }

        private void btnMakeBIdentity_Click(object sender, EventArgs e)
        {
            if (IsValidData(txtMatrixBRows) && IsValidData(txtMatrixBCols))
            {
                MakeIdentityMatrix(Convert.ToInt32(txtMatrixBRows.Text), Convert.ToInt32(txtMatrixBCols.Text));
                txtMatrixB.Text = MatrixToString(B);
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbnMultiply.Checked)
            {
                MultiplyMatrix();
                txtMatrixC.Text = MatrixToString(C);
            }
            else if (rbnAdd.Checked && (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1)))
            {
                AddMatrix();
                txtMatrixC.Text = MatrixToString(C);
            }
            else
            {
                if ((A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1)))
                {
                    SubtractMatrix();
                    txtMatrixC.Text = MatrixToString(C);
                }
            }
        }

        private void SubtractMatrix()
        {
            C = new double[A.GetLength(0), A.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] - B[i, j];
                }
            }
        }

        private void AddMatrix()
        {
            C = new double[A.GetLength(0), A.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < A.GetLength(1); j++)
                {
                    C[i, j] = A[i, j] + B[i, j];
                }
            }
        }

        private void MultiplyMatrix()
        {
            C = new double[A.GetLength(0), B.GetLength(1)];

            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        C[i, j] += A[i, k] * B[k, j];
                        Math.Round(C[i, j], 1);
                    }
                }
            }   
        }

        private void txtMatrixARows_TextChanged(object sender, EventArgs e)
        { /*
            if (txtMatrixARows.Text == null)
            {
                MessageBox.Show("Please enter a value before leaving the text box.");
                txtMatrixARows.Focus();
            }*/
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            A = null;
            B = null;
            C = null;

            txtMatrixA.Text = "";
            txtMatrixB.Text = "";
            txtMatrixC.Text = "";
        }
    }
}
