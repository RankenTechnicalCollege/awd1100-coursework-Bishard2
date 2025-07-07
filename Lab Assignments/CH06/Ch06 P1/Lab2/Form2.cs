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
            lblResults.Text = "";
        }

        private void txtGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAdTestScore_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdmit_Click(object sender, EventArgs e)
        {
            float gpa;
            int score;
            if (!float.TryParse(txtGPA.Text.Trim(), out gpa))
            {
                MessageBox.Show("Please enter a valid GPA.");
                txtGPA.Focus();
                return;
            }
            if (gpa < 0.0f || gpa > 5.0f)
            {
                MessageBox.Show("GPA out of range.");
                txtGPA.Focus();
                return;
            }
            if (!int.TryParse(txtTestScore.Text.Trim(), out score))
            {
                MessageBox.Show("Please enter a valid test score.");
                txtTestScore.Focus();
                return;
            }
            if (score < 0 || score > 100)
            {
                MessageBox.Show("Test score out of range.");
                txtTestScore.Focus();
                return;
            }
            bool accepted = IsStudentAccepted(gpa, score);
            lblResults.Text = accepted ? "Accept" : "Reject";
        }
        private bool IsStudentAccepted(float gpa, int testScore)
        {
            if (gpa >= 3.0f && testScore >= 60)
                return true;
            if (gpa < 3.0f && testScore >= 80)
                return true;
            return false;
        }
    }
}
