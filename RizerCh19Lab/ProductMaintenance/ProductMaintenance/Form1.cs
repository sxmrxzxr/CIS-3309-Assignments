using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mMABooksDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mMABooksDataSet.Products' table. You can move, or remove it, as needed.

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                int custId = Convert.ToInt32(toolStripTxtProductCode.Text);
                this.productsTableAdapter.FillByProductCode(this.mMABooksDataSet.Products, custId);
            }
            catch
            {

            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.productsTableAdapter.Fill(this.mMABooksDataSet.Products);
        }

        private void productsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
