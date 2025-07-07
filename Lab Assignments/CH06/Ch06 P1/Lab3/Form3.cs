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
            lblResult.Text = "";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text;
            int vowelCount = CountVowels(phrase);
            lblResult.Text = $"There are {vowelCount} vowel{(vowelCount == 1 ? "" : "s")} in your phrase";
        }
        private int CountVowels(string phrase)
        {
            if (string.IsNullOrEmpty(phrase))
                return 0;

            int count = 0;
            foreach (char ch in phrase)
            {
                switch (char.ToLowerInvariant(ch))
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        count++;
                        break;
                    default:
                        break;
                }
            }
            return count;
        }
    }
}
