using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class Form1 : Form
    {
        public const double CM_PER_IN = 2.54;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtInches.Text.Trim(), out double inches))
            {
                lblResult.Text = "Please enter a valid number.";
                return;
            }
            double cm = inches * CM_PER_IN;
            lblResult.Text = $"{inches} inches is {cm:F2} centimeters";
        }
    }
}
