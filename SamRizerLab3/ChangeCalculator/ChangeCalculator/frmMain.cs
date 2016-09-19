using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private int[] makeChange(int c)
        {
            int[] coins = new int[] { 25, 10, 5, 1 };
            int[] change = new int[4];

            for (int i = 0; i < coins.Length; i++)
            {
                int count = (int)(c / coins[i]);
                c -= count * coins[i];
                change[i] = count;
            }

            return change;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int change = Convert.ToInt32(txtChange.Text);
                int[] coins = makeChange(change);

                txtQuarters.Text = coins[0].ToString();
                txtDimes.Text = coins[1].ToString();
                txtNickels.Text = coins[2].ToString();
                txtPennies.Text = coins[3].ToString();
            }
            catch
            {
                MessageBox.Show("Please enter a valid integer.");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
