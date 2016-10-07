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

        public string MatrixToString(double[,] x)
        {
            string s = "";
            
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    s += x[i, j].ToString() + "\t";
                }
                s += "\n";
            }
            
            return s;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMakeMatrixA_Click(object sender, EventArgs e)
        {            
            if (IsValidData())
            {
                A = MakeMatrix(Convert.ToInt32(txtMatrixARows.Text), Convert.ToInt32(txtMatrixACols.Text));
                txtMatrixA.Text = MatrixToString(A);
            }
        }

        private void btnMakeMatrixB_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                B = MakeMatrix(Convert.ToInt32(txtMatrixBRows.Text), Convert.ToInt32(txtMatrixBCols.Text));
                txtMatrixB.Text = MatrixToString(B);
            }
        }

        private bool IsValidData()
        {
            return true;
        }        
    }
}
