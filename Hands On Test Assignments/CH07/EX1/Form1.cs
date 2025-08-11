using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        private TestStatistics _stats = new TestStatistics();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            float score;

            if (float.TryParse(txtScore.Text, out score))
            {
                try
                {
                    _stats.AddScore(score);
                    lblError.Text = "";
                    UpdateStatsDisplay();
                }
                catch (ArgumentException)
                {
                    lblError.Text = "Score must be between 0 and 100.";
                }
            }
            else
            {
                lblError.Text = "Please enter a valid number.";
            }
        }
             private void UpdateStatsDisplay()
        {
            lblCount.Text = $"Number of scores: {_stats.Count}";
            lblSum.Text = $"Sum of test scores: {_stats.Sum}";
            lblAverage.Text = $"Average test score: {_stats.Average}";
            lblMin.Text = $"Lowest test score: {_stats.Min}";
            lblMax.Text = $"Highest Test Score: {_stats.Max}";
        }
    }
}
