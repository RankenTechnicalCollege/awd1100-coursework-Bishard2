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

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txt1.Text, out int num1) ||
                !int.TryParse(txt2.Text, out int num2) ||
                !int.TryParse(txt3.Text, out int num3) ||
                !int.TryParse(txt4.Text, out int num4))
            {
                MessageBox.Show("Please enter four valid integers.");
                return;
            }

            Reverse4(ref num1, ref num2, ref num3, ref num4);

            txt1.Text = num1.ToString();
            txt2.Text = num2.ToString();
            txt3.Text = num3.ToString();
            txt4.Text = num4.ToString();
        }
        public void Reverse4(ref int num1, ref int num2, ref int num3, ref int num4)
        {
            int temp = num1;
            num1 = num4;
            num4 = temp;

            temp = num2;
            num2 = num3;
            num3 = temp;
        }
    }
}
