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
        DateTime today;
        public Form1()
        {
            InitializeComponent();
        }

        public bool IsValidData()
        {
            if (IsDateTime(txtArrivalDate, "Arrival Date") && IsDateTime(txtDepartureDate, "Departure Date") && IsWithinRange(txtArrivalDate, "Arrival Date", DateTime.Today, DateTime.MaxValue) && IsWithinRange(txtDepartureDate, "Departure Date", DateTime.Today, DateTime.MaxValue))
            {
                return true;
            }

            return false;
        }

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

        public bool IsDateTime(TextBox textBox, string name)
        {
            DateTime d = new DateTime();
            return DateTime.TryParse(textBox.Text, out d);
        }

        public bool IsWithinRange(TextBox textBox, string name, DateTime min, DateTime max)
        {
            DateTime d = Convert.ToDateTime(textBox.Text);
            return (min <= d) && (d <= max);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (IsValidData())
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
            else
            {
                MessageBox.Show("Please Enter Valid Dates");
                txtArrivalDate.Text = today.Date.ToShortDateString();
                txtDepartureDate.Text = today.AddDays(3).Date.ToShortDateString();
                txtArrivalDate.Focus();
            }
            
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            today = DateTime.Today;

            txtArrivalDate.Text = today.Date.ToShortDateString();
            txtDepartureDate.Text = today.AddDays(3).Date.ToShortDateString();
        }
    }
}