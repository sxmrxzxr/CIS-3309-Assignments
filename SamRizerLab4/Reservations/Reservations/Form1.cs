using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reservations
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //public bool IsValidData()
        //{

        //}

        public bool IsPresent(TextBox textBox, string name)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(name + " is a required field.", "Entry Error");
                textBox.Focus();
                return false;
            }
            return true;
        }

        /*public bool IsDateTime(TextBox textBox, string name)
        {
            Convert.ToDateTime(textBox.Text);
        }*/

        //public bool IsWithinRange(TextBox textBox, string name,
        //    DateTime min, DateTime max)
        //{

        //}

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            DateTime arrivalDate = Convert.ToDateTime(txtArrivalDate.Text);
            DateTime departureDate = Convert.ToDateTime(txtDepartureDate.Text);

            double nights = (departureDate - arrivalDate).TotalDays;
            double nightCount = 0;
            double price = 0;

            while (nightCount < nights)
            {
                //MessageBox.Show(arrivalDate.AddDays(nightCount).DayOfWeek.ToString());

                if (arrivalDate.AddDays(nightCount).DayOfWeek.Equals(DayOfWeek.Friday) || arrivalDate.AddDays(nightCount).DayOfWeek.Equals(DayOfWeek.Saturday))
                {
                    price += 150;
                }
                else
                {
                    price += 120;
                }

                nightCount++;
            }

            double avgPrice = price / nights;

            txtNights.Text = nights.ToString();
            txtTotalPrice.Text = price.ToString();
            txtAvgPrice.Text = avgPrice.ToString();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Today;

            txtArrivalDate.Text = today.Date.ToShortDateString();
            txtDepartureDate.Text = today.AddDays(3).Date.ToShortDateString();
        }
    }
}