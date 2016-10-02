using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceTotal
{
    public partial class frmSalesTax : Form
    {

        public frmSalesTax()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal salesTax = Convert.ToDecimal(txtInput.Text);
            Tag = salesTax;
        }
    }
}
