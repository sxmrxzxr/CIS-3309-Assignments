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
        Matrix A;
        Matrix B;
        Matrix C;

        public frmMain()
        {
            InitializeComponent();
            rbnMultiply.Checked = true;
        }
        

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMakeMatrixA_Click(object sender, EventArgs e)
        {
            A = new Matrix(Convert.ToInt32(txtMatrixARows.Text), Convert.ToInt32(txtMatrixACols.Text));
            A.PopulateRand();

            txtMatrixA.Text = A.ToString();
        }

        private void btnMakeMatrixB_Click(object sender, EventArgs e)
        {
            B = new Matrix(Convert.ToInt32(txtMatrixBRows.Text), Convert.ToInt32(txtMatrixBCols.Text));
            B.PopulateRand();

            txtMatrixB.Text = B.ToString();
        }

        private bool IsValidData(TextBox t)
        {
            return true;
        }

        private void btnMakeBIdentity_Click(object sender, EventArgs e)
        {
            B = new Matrix(Convert.ToInt32(txtMatrixBRows.Text), Convert.ToInt32(txtMatrixBCols.Text));
            B.MakeId();

            txtMatrixB.Text = B.ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (rbnAdd.Checked)
                C = A + B;
            else if (rbnSubtract.Checked)
                C = A - B;
            else if (rbnMultiply.Checked)
                C = A * B;
            else
                MessageBox.Show((A == B).ToString());

            txtMatrixC.Text = C.ToString();
        }

        private void txtMatrixARows_TextChanged(object sender, EventArgs e)
        { 

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

        private void btnCopy_Click(object sender, EventArgs e)
        {
            B = A;

            txtMatrixB.Text = B.ToString();
        }
    }
}
