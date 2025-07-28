using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private Job currentJob;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string desc = txtDescription.Text.Trim();
            double.TryParse(txtHours.Text.Trim(), out double hours);
            double.TryParse(txtRate.Text.Trim(), out double rate);

            if (currentJob == null)
            {
                currentJob = new Job(desc, hours, rate);
            }
            else
            {
                currentJob.Description = desc;
                currentJob.HoursToComplete = hours;
                currentJob.HourlyFee = rate;
            }

            lblDescription.Text = currentJob.Description;
            lblHours.Text = currentJob.HoursToComplete.ToString("0.0") + " hours";
            lblRate.Text = "$" + currentJob.HourlyFee.ToString("0.00");
            lblTotal.Text = "$" + currentJob.TotalFee.ToString("0.00");
        }
    }
}
