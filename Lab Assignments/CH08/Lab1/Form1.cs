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
        private readonly string[] zips = {
            "63101","63103","63105","63109","63113",
            "63118","63130","63133","63136","63137"
        };
        private readonly decimal[] charges = {
            20m, 12m, 25m, 15m, 10m,
            23m, 18m, 20m, 17m, 12m
        };
        public Form1()
        {
            InitializeComponent();
            lblCharge.Text = "";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            lblCharge.Text = "";
            string input = txtZip.Text.Trim();
            for (int i = 0; i < zips.Length; i++)
            {
                if (zips[i] == input)
                {
                    lblCharge.Text = $"{charges[i]:C}";
                    return;
                }
            }
            lblCharge.Text = "Zip not found";
        }
    }
}
