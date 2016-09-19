using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        
        private bool IsPreset(TextBox t, string name)
        {
            if (t.Text == "")
            {
                MessageBox.Show(name + " is a required field");
                t.Focus();
                return false;
            }
            return true;
        }

        private bool IsDecimal(TextBox t, string name)
        {
            decimal num = 0m;

            if (Decimal.TryParse(t.Text, out num))
            {
                return true;
            }
            else
            {
                MessageBox.Show(name + " is a required field.");
                t.Focus();
                return false;
            }
        }

        private bool IsWithinRange(TextBox t, string name, decimal min, decimal max)
        {
            decimal num = Convert.ToDecimal(t.Text);

            if (num < min || num > max)
            {
                MessageBox.Show(name + " must be between " + min.ToString() + " and " + max.ToString() + ".");
                t.Focus();
                return false;
            }
            return true;
        }

        private decimal Calculate(decimal o1, decimal o2, string o)
        {
            switch (o)
            {
                case "+":
                    return o1 + o2;
                case "-":
                    return o1 - o2;
                case "*":
                    return o1 * o2;
                case "/":
                    return Math.Round(o1 / o2, 4);
                default:
                    return 0; //error
            }
        }

        private bool IsValidData()
        {
            if (!IsPreset(txtOperand1, "Operand 1"))
                return false;
            if (!IsDecimal(txtOperand1, "Operand 1"))
                return false;
            if (!IsWithinRange(txtOperand1, "Operand 1", 1, 100000))
                return false;

            if (!IsPreset(txtOperand2, "Operand 2"))
                return false;
            if (!IsDecimal(txtOperand2, "Operand 2"))
                return false;
            if (!IsWithinRange(txtOperand2, "Operand 2", 1, 1000000))
                return false;

            if (!IsPreset(txtOperator, "Operator"))
                return false;
            if (!IsDecimal(txtOperator, "Operator"))
                return false;
            if (!IsWithinRange(txtOperator, "Operator", 1, 1000))
                return false;

            return true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                decimal operand1 = Convert.ToDecimal(txtOperand1.Text);
                decimal operand2 = Convert.ToDecimal(txtOperand2.Text);
                string operater = Convert.ToString(txtOperator.Text);

                if (IsValidData())
                {
                    txtResult.Text = Calculate(operand1, operand2, operater).ToString();
                    txtOperand1.Focus();
                } 
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Please enter a valid input, " + ex.StackTrace);
                txtOperand1.Clear();
                txtOperand2.Clear();
                txtOperator.Clear();
                txtOperand1.Focus();
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("No, " + ex.StackTrace);
                txtOperand1.Clear();
                txtOperand2.Clear();
                txtOperator.Clear();
                txtOperand1.Focus();
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Do not divide by zero, " + ex.StackTrace);
                txtOperand2.Clear();
                txtOperand2.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
