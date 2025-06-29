using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersice3
{
    public partial class Form3 : Form
    {
        private const int SEASON_WEEKS = 20;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtLength.Text.Trim(), out double length) || length <= 0 ||
               !double.TryParse(txtWidth.Text.Trim(), out double width) || width <= 0)
            {
                MessageBox.Show("Please enter positive numeric values for length and width.",
                                "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            double area = length * width;
            lblArea.Text = $"Area: {area:0.#} sq ft";

            double weeklyFee;
            if (area >= 600)
                weeklyFee = 50;
            else if (area >= 400)
                weeklyFee = 35;
            else
                weeklyFee = 25;

            lblFee.Text = $"Weekly Fee: ${weeklyFee:0.##}";

            double total = weeklyFee * SEASON_WEEKS;
            lblSeason.Text = $"Season Length: {SEASON_WEEKS} weeks";
            lblTotalCost.Text = $"Total Cost: ${total:0.##}";
        }
    }
}
