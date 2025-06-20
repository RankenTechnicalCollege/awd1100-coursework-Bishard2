using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {

        private int countScores;
        private double sumScores;
        private int minScore;
        private int maxScore;
        private bool finished;
        public Form1()
        {
            InitializeComponent();
            InitializeStatistics();

            lblMessage.Text = "";
            lblCount.Text = "";
            lblSum.Text = "";
            lblAverage.Text = "";
            lblMin.Text = "";
            lblMax.Text = "";
        }

        private void InitializeStatistics()
        {
            countScores = 0;
            sumScores = 0.0;
            minScore = int.MaxValue;
            maxScore = int.MinValue;
            finished = false;
        }
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (finished)
            {
                return;
            }

            lblMessage.Text = "";
            string input = txtScore.Text.Trim();

            if (!int.TryParse(input, out int score))
            {
                ShowInvalid();
                return;
            }

            if (score == 999)
            {
                DisplayResults();
                finished = true;
                txtScore.Enabled = false;
                btnEnter.Enabled = false;
                return;
            }

            if (score >= 0 && score <= 100)
            {
                countScores++;
                sumScores += score;
                if (score < minScore) minScore = score;
                if (score > maxScore) maxScore = score;

                txtScore.Clear();
                txtScore.Focus();
            }
            else
            {
                ShowInvalid();
                return;
            }
        }
        private void ShowInvalid()
        {
            lblMessage.Text = "Invalid score";
            txtScore.SelectAll();
            txtScore.Focus();
        }
        private void DisplayResults()
        {
            lblMessage.Text = "";
            if (countScores > 0)
            {
                double average = sumScores / countScores;
                lblCount.Text = $"Number of scores: {countScores}";
                lblSum.Text = $"Sum of test scores: {sumScores:F1}";
                lblAverage.Text = $"Average test score: {average:F1}";
                lblMin.Text = $"Lowest test score: {minScore:F1}";
                lblMax.Text = $"Highest test score: {maxScore:F1}";
            }
            else
            {
                lblCount.Text = "No valid scores were entered.";
                lblSum.Text = "";
                lblAverage.Text = "";
                lblMin.Text = "";
                lblMax.Text = "";
            }
        }
    }
}

