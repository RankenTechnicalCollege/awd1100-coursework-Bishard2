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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            double userGPA = Convert.ToDouble(txtGPA.Text);

            double userScore = Convert.ToDouble(txtScore.Text);

            if (userGPA >= 3.0 && userScore >= 60)
            {
                lblResult.Text = "Accepted";
            }
            else if (userGPA <= 3.0 && userScore >= 80)
            {
                lblResult.Text = "Accepted";
            }
            else
            {
                lblResult.Text = "Rejected";
            }
        }

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }
    }
}
