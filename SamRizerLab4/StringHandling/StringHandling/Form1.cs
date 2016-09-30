using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringHandling
{
    public partial class Form1 : Form
    {
        private string username;
        private string domain;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void ParseEmail(string e)
        {
            username = e.Split('@')[0];
            domain = e.Split('@')[1];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnParse_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Contains('@'))
            {
                string email = txtEmail.Text.Trim();
                ParseEmail(email);
                MessageBox.Show("username: " + username + "\ndomain: " + domain);
            }
            else
            {
                MessageBox.Show("Please enter a valid email address.");
                txtEmail.Clear();
                txtEmail.Focus();
            }
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            MessageBox.Show("City, State, Zip: " + txtCity.Text + ", " + txtState.Text.ToUpper() + ", " + txtZipCode.Text);
        }
    }
}
