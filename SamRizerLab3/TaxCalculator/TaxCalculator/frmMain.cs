using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private double CalculateTax(int i)
        {
            if (i > 0 && i <= 9225)
            {
                return 0 + (i * .10);
            }
            else if (i > 9225 && i <= 37450)
            {
                return 922.50 + ((i - 9225) * 0.15);
            }
            else
            {
                return 1; //error i didn't think of
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int income = Convert.ToInt32(txtIncome.Text);
                double taxed = CalculateTax(income);
                txtTax.Text = taxed.ToString();
            }
            catch
            {
                MessageBox.Show("Enter a valid input.");
                txtIncome.Clear();
                txtIncome.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
