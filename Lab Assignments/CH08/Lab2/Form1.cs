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
        private readonly int[] minNights = { 1, 3, 5, 8 };
        private readonly decimal[] rates = { 200m, 180m, 160m, 145m };
        public Form1()
        {
            InitializeComponent();
            lblNightlyRate.Text = "";
            lblTotalCost.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblNightlyRate.Text = "";
            lblTotalCost.Text = "";

            if (!int.TryParse(txtNights.Text.Trim(), out int nights) || nights < 1)
            {
                MessageBox.Show("Enter a valid positive integer for nights.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            decimal nightlyRate = rates[rates.Length - 1];

            for (int i = 0; i < minNights.Length - 1; i++)
            {
                if (nights < minNights[i + 1])
                {
                    nightlyRate = rates[i];
                    break;
                }
            }
            decimal total = nightlyRate * nights;
            lblNightlyRate.Text = nightlyRate.ToString("C");
            lblTotalCost.Text = total.ToString("C");
        }
    }
}
