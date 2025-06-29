using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersise2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtGPA.Text.Trim(), out double gpa))
            {
                lblResult.Text = "Your Grade: Please enter a valid number.";
                return;
            }
            if (gpa < 0.0 || gpa > 4.0)
            {
                lblResult.Text = "Your Grade: GPA must be 0.0–4.0.";
                return;
            }
            string letter;
            if (gpa > 3.0) letter = "A";
            else if (gpa > 2.0) letter = "B";
            else if (gpa > 1.0) letter = "C";
            else if (gpa > 0.0) letter = "D";
            else letter = "F";

            lblResult.Text = $"Your Grade: {letter}";
        }
    }
}
