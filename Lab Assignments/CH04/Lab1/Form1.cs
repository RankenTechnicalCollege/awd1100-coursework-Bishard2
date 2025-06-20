using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private const decimal KM_PER_MILE = 1.6m;
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void btnKm_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string milesText = txtMiles.Text;
            if (string.IsNullOrEmpty(milesText))
            {
                MessageBox.Show("Please enter a distance in miles.", "Input needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMiles.Focus();
                return;
            }
            if (!decimal.TryParse(milesText, out decimal miles) || miles < 0)
            {
                MessageBox.Show("Enter a valid non-negative number for miles.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMiles.SelectAll();
                txtMiles.Focus();
                return;
            }
            decimal km = miles * KM_PER_MILE;
            txtKm.Text = km.ToString("0.####");
            lblResult.Text = $"{miles:0.####} miles is {km:0.####} kilometers";
        }

        private void btnMiles_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            string kmText = txtKm.Text.Trim();
            if (string.IsNullOrEmpty(kmText))
            {
                MessageBox.Show("Please enter a distance in kilometers.", "Input needed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKm.Focus();
                return;
            }
            if (!decimal.TryParse(kmText, out decimal km) || km < 0)
            {
                MessageBox.Show("Enter a valid non-negative number for kilometers.", "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtKm.SelectAll();
                txtKm.Focus();
                return;
            }
            decimal miles = km / KM_PER_MILE;
            txtMiles.Text = miles.ToString("0.####");
            lblResult.Text = $"{km:0.####} kilometers is {miles:0.####} miles";
        }
    }
}
