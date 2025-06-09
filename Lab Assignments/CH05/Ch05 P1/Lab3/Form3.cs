using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            int rock = 1;
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int paper = 2;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            int scissors = 3;
        }
    }
}
