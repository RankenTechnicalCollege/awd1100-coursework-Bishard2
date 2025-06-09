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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            double windSpeed = Convert.ToDouble(txtSpeed.Text);

            if (windSpeed >= 157)
            {
                txtResult.Text = "Category 5";
            }
            else if (windSpeed >= 130 && windSpeed < 157)
            {
                txtResult.Text = "Category 4";
            }
            else if (windSpeed >= 111 && windSpeed < 130)
            {
                txtResult.Text = "Category 3";
            }
            else if (windSpeed >= 96 && windSpeed < 111)
            {
                txtResult.Text = "Category 2";
            }
            else if (windSpeed >= 74 && windSpeed < 96)
            {
                txtResult.Text = "Category 1";
            }
            else
            {
                txtResult.Text = "Not A Hurricane";
            }
        }
    }
}
