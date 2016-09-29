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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int total = 0;
        int count = 0;

        int[] scoreArray = new int[20];

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int score = Convert.ToInt32(txtScore.Text);
                scoreArray[count] = score;
                total += score;
                count += 1;
                int average = total / count;
                txtAverage.Text = average.ToString();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid input, please enter a number.");
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("You cannot enter anymore scores.");
            }
            finally
            {
                txtScoreTotal.Text = total.ToString();
                txtScoreCount.Text = count.ToString();
                txtScore.Focus();
            }           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            total = 0;
            count = 0;

            scoreArray = new int[20];

            txtScore.Text = "";
            txtScoreTotal.Text = "";
            txtScoreCount.Text = "";
            txtAverage.Text = "";
            txtScore.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            Array.Sort(scoreArray);
            string scoreList = "";

            for (int i = 0; i < count; i++)
            {
                if (scoreArray[i] != 0)
                {
                    scoreList += scoreArray[i].ToString() + "\n";
                }
            }

            MessageBox.Show(scoreList);
        }
    }
}