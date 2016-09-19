using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFactorial
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private decimal Factor(decimal x)
        {
            if (x >= 1)
            {
                return x * Factor(x-1);
            }
            else
            {
                return 1;
            }

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                txtFactorial.Clear();
                txtFactorial.Text = Factor(Convert.ToDecimal(txtNumber.Text)).ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Enter a valid input");
                txtNumber.Clear();
                txtFactorial.Clear();
            }
        }
    }
}
