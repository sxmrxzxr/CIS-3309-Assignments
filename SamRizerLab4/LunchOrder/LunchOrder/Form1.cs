using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ClearTotals()
        {
            lblOrderTotal.Text = " ";
            lblSalesTax.Text = " ";
            lblSubtotal.Text = " ";
        }

        private void ClearAllAddons()
        {
            foreach (CheckBox c in gbxAddOns.Controls)
            {
                c.Checked = false;
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0;
            decimal salestax = 0.0775m;
            decimal ordertotal = 0;

            if (rbHamburger.Checked)
            {
                subtotal += 6.95m;

                foreach (CheckBox c in gbxAddOns.Controls)
                {
                    if (c.Checked)
                    {
                        subtotal += 0.75m;
                    }
                }

                ordertotal = subtotal + (subtotal * salestax);
            } 
            else if (rbPizza.Checked)
            {
                subtotal += 5.95m;

                foreach (CheckBox c in gbxAddOns.Controls)
                {
                    if (c.Checked)
                    {
                        subtotal += 0.50m;
                    }
                }

                ordertotal = subtotal + (subtotal * salestax);
            }
            else if (rbSalad.Checked)
            {
                subtotal += 4.95m;

                foreach (CheckBox c in gbxAddOns.Controls)
                {
                    if (c.Checked)
                    {
                        subtotal += 0.25m;
                    }
                }

                ordertotal = subtotal + (subtotal * salestax);
            }
            else
            {

            }

            lblSubtotal.Text = subtotal.ToString();
            lblSalesTax.Text = salestax.ToString();
            lblOrderTotal.Text = ordertotal.ToString();
        }

        private void rbPizza_CheckedChanged(object sender, EventArgs e)
        {
            chkLTO.Text = "Pepperoni";
            chkKM.Text = "Sausage";
            chkFries.Text = "Olives";
            gbxAddOns.Text = "Add-ons $0.50/each";
        }

        private void rbSalad_CheckedChanged(object sender, EventArgs e)
        {
            chkLTO.Text = "Croutons";
            chkKM.Text = "Bacon Bits";
            chkFries.Text = "Bread Sticks";
            gbxAddOns.Text = "Add-ons $0.25/each";
        }

        private void rbHamburger_CheckedChanged(object sender, EventArgs e)
        {
            chkLTO.Text = "Lettuce, Tomato, Onions";
            chkKM.Text = "Ketchup, Mustard, and Mayo";
            chkFries.Text = "French Fries";
            gbxAddOns.Text = "Add-ons $0.75/each";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbHamburger.Checked = true;
        }
    }
}