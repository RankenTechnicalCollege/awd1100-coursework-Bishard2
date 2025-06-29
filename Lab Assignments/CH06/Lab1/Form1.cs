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
        private readonly string[] _fortunes = new[]
        {
            "Birthdays are like friends. The more you have the better.",
            "Your smile is a treasure to all who know you.",
            "You never hesitate to tackle the most difficult problems.",
            "The most obvious solution is not always the best.",
            "If you want the rainbow, you will have to tolerate the rain.",
            "The early bird gets the worm, but the second mouse gets the cheese.",
            "From listening comes wisdom and from speaking repentance.",
            "A smile is your personal welcome mat."
        };
        private readonly Random _rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            GenerateFortune();
        }
        private void GenerateFortune()
        {
            if (_fortunes.Length < 2)
            {
                lblMessage.Text = "Not enough fortune entries.";
                return;
            }

            // pick first random index
            int firstIndex = _rnd.Next(_fortunes.Length);
            int secondIndex;

            // pick a different random index
            do
            {
                secondIndex = _rnd.Next(_fortunes.Length);
            } while (secondIndex == firstIndex);

            string fortune1 = _fortunes[firstIndex];
            string fortune2 = _fortunes[secondIndex];

            // Display them in the TextBox, separated by a blank line (or just newline)
            lblMessage.Text = fortune1 + Environment.NewLine + Environment.NewLine + fortune2;
        }
    }
}
