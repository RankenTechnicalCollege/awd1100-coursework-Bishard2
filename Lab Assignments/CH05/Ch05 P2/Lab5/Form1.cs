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
        public Form1()
        {
            InitializeComponent();
            lblResult.Text = "";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string phrase = txtPhrase.Text ?? "";
            int vowelCount = 0;

            for (int i = 0; i < phrase.Length; i++)
            {
                string sChar = phrase.Substring(i, 1);
                char c = sChar.ToLower()[0];

                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        vowelCount++;
                        break;
                    default:
                        break;
                }
            }
            lblResult.Text = $"There are {vowelCount} vowels in your phrase";
        }
    }
}
