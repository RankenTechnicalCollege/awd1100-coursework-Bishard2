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
        private string MaskNumber(string unmaskedCC, char replacementChar, int numDigitsToPreserve)
        {
            int totalAlphanumeric = unmaskedCC.Count(c => char.IsLetterOrDigit(c));
            int toMask = Math.Max(0, totalAlphanumeric - numDigitsToPreserve);

            var result = new StringBuilder(unmaskedCC.Length);
            int maskedSoFar = 0;

            foreach (char c in unmaskedCC)
            {
                if (char.IsLetterOrDigit(c))
                {
                    if (maskedSoFar < toMask)
                    {
                        result.Append(replacementChar);
                        maskedSoFar++;
                    }
                    else
                    {
                        result.Append(c);
                    }
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
        private void btnMask_Click(object sender, EventArgs e)
        {
            const int numDigitsToPreserve = 4;
            string input = txtInput.Text;
            lblOutput.Text = MaskNumber(input, '#', numDigitsToPreserve);
        }
    }
}
