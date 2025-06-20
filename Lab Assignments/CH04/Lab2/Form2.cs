using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
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
            lblResult.Text = "";
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {


        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lblResult.Text = "";
            if (!TryGetEggCount(txtEgg1.Text.Trim(), out int e1)) return;
            if (!TryGetEggCount(txtEgg2.Text.Trim(), out int e2)) return;
            if (!TryGetEggCount(txtEgg3.Text.Trim(), out int e3)) return;
            if (!TryGetEggCount(txtEgg4.Text.Trim(), out int e4)) return;

            int total = e1 + e2 + e3 + e4;
            int dozen = total / 12;
            int remainder = total % 12;

            lblResult.Text = $"{total} eggs total, or {dozen} dozen and {remainder} eggs";
        }
        private bool TryGetEggCount(string text, out int value)
        {
            value = 0;
            TextBox offending = null;

            if (txtEgg1.Text.Trim() == text) offending = txtEgg1;
            else if (txtEgg2.Text.Trim() == text) offending = txtEgg2;
            else if (txtEgg3.Text.Trim() == text) offending = txtEgg3;
            else if (txtEgg4.Text.Trim() == text) offending = txtEgg4;

            if (!int.TryParse(text, out value) || value < 0)
            {
                MessageBox.Show("Enter a valid non-negative integer for eggs.", "invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                if (offending != null)
                {
                    offending.SelectAll();
                    offending.Focus();
                }
                return false;
            }
            return true;
        }
    }
}
