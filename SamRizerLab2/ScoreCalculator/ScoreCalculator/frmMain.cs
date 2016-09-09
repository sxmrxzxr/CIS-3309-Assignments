using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScoreCalculator
{
    public partial class frmMain : Form
    {

        decimal scoreTotal = 0;
        decimal scoreCount = 0;

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            scoreTotal += Convert.ToDecimal(txtScore.Text);
            scoreCount++;

            txtScore.Text = "";
            txtTotal.Text = scoreTotal.ToString();
            txtCount.Text = scoreCount.ToString();
            txtAverage.Text = (scoreTotal / scoreCount).ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            scoreTotal = 0;
            scoreCount = 0;

            txtScore.Text = "";
            txtTotal.Text = "";
            txtCount.Text = "";
            txtAverage.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
