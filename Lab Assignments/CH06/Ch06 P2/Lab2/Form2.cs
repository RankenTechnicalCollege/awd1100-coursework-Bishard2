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
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            string input = txtPhrase.Text.Trim();
            if (input.Length == 0)
            {
                MessageBox.Show("Please enter a phrase first.");
                return;
            }

            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            SortWords(words);

            txtSorted.Text = string.Join(" ", words);
        }
        public void SortWords(string[] unsortedWords)
        {
            for (int i = 0; i < unsortedWords.Length - 1; i++)
            {
                for (int j = i + 1; j < unsortedWords.Length; j++)
                {
                    if (string.Compare(unsortedWords[i], unsortedWords[j], StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        string temp = unsortedWords[i];
                        unsortedWords[i] = unsortedWords[j];
                        unsortedWords[j] = temp;
                    }
                }
            }
        }
    }
}
