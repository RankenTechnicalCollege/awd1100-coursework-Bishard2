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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnMask_Click(object sender, EventArgs e)
        {
            const int numToUnmask = 4;
            lblResult.Text = MaskNumber(txtCC.Text, numToUnmask, '#');
        }
        private string MaskNumber(string input, int numUnmasked, char replacementChar)
        {
            if (input == null)
                return "";

            int n = input.Length;
            int cutoff = Math.Max(0, n - numUnmasked);

            char[] result = new char[n];
            for (int i = 0; i < n; i++)
            {
                char c = input[i];
                if (i >= cutoff)
                {
                    result[i] = c;
                }
                else if (char.IsLetterOrDigit(c))
                {
                    result[i] = replacementChar;
                }
                else
                {
                    result[i] = c;
                }
            }

            return new string(result);
        }
    }
}
