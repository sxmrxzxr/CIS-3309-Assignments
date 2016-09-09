using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreadAndPerimeterApp
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //this.AcceptButton = Enter;
            decimal length = Convert.ToDecimal(txtLength.Text);
            decimal width = Convert.ToDecimal(txtWidth.Text);

            decimal area = length * width;
            decimal perimeter = (length * 2) + (width * 2);

            txtArea.Text = area.ToString();
            txtPerimeter.Text = perimeter.ToString();
        }
    }
}
