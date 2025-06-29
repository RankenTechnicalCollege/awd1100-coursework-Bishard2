using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            lblArea.Text = "";
            lblCost.Text = "";
        }
        private int CalculateTotalArea(int length, int width)
        {
            const int height = 9;
            int area = 2 * (length * height) + 2 * (width * height);
            return area;
        }
        private double CalculatePaintEstimate(int totalArea)
        {
            const double pricePerSqFt = 6.0;
            return totalArea * pricePerSqFt;
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtLength.Text.Trim(), out int length) || length <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer for Length (ft).",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLength.Focus();
                return;
            }
            if (!int.TryParse(txtWidth.Text.Trim(), out int width) || width <= 0)
            {
                MessageBox.Show("Please enter a valid positive integer for Width (ft).",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWidth.Focus();
                return;
            }
            int totalArea = CalculateTotalArea(length, width);
            double totalCost = CalculatePaintEstimate(totalArea);

            lblArea.Text = totalArea.ToString("N0");
            lblCost.Text = totalCost.ToString("C2");
        }
    }
}
