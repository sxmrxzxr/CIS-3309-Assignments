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
    public partial class frmAddModifyProduct : Form
    {
        public frmAddModifyProduct()
        {
            InitializeComponent();
        }

        public bool addProduct;
        public Product product;

        private void frmAddModifyProduct_Load(object sender, EventArgs e)
        {
            if (addProduct)
            {
                this.Text = "Add Product";
                txtCode.ReadOnly = false;
                txtCode.TabStop = true;
                txtCode.Focus();
            }
            else
            {
                this.Text = "Modify Product";
                txtCode.ReadOnly = true;
                txtCode.TabStop = false;
                txtDescription.Focus();
                this.DisplayProduct();
            }
        }

        private void DisplayProduct()
        {
            txtCode.Text = product.Code;
            txtDescription.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                if (addProduct)
                {
                    product = new Product();
                    this.PutProductData(product);
                    try
                    {
                        // Add code here to call the AddProduct method of the ProductDB class.
                        bool result = ProductDB.AddProduct(product);
                        if (result)
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            DialogResult = DialogResult.Retry;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
                else
                {
                    Product newProduct = new Product();
                    this.PutProductData(newProduct);
                    try
                    {
                        // Add code here to call the UpdateProduct method of the ProductDB class.
                        bool result = ProductDB.UpdateProduct(product, newProduct);
                        if (result)
                        {
                            product = newProduct;
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Error, another user has updated or deleted the product");
                            DialogResult = DialogResult.Retry;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, ex.GetType().ToString());
                    }
                }
            }
        }

        private bool IsValidData()
        {
            return
                Validator.IsPresent(txtCode) &&
                Validator.IsPresent(txtDescription) &&
                Validator.IsPresent(txtPrice) &&
                Validator.IsDecimal(txtPrice);
        }

        private void PutProductData(Product product)
        {
            product.Code = txtCode.Text;
            product.Description = txtDescription.Text;
            product.Price = Convert.ToDecimal(txtPrice.Text);
        }
    }
}
