using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Lab_1
{
    public partial class Form1 : Form
    {
        private List<FlashCard> flashCards = new List<FlashCard>();
        private const int MaxCards = 20;
        public Form1()
        {
            InitializeComponent();
            LoadInitialCards();
        }

        private void LoadInitialCards()
        {
            flashCards.Add(new FlashCard("Variable", "A variable is a named memory location."));
            flashCards.Add(new FlashCard("loop", "A loop repeats a block of code."));
            flashCards.Add(new FlashCard("array", "Anchor array stores mulitple values in one variable."));
            flashCards.Add(new FlashCard("class", "A class defines a blueprint for objects."));
            flashCards.Add(new FlashCard("method", "A method performs a specific task in code."));
        }
        private void btnDefine_Click(object sender, EventArgs e)
        {
            string input = txtTerm.Text.Trim().ToLower();
            FlashCard found = flashCards.FirstOrDefault(SizeFConverter => SizeFConverter.GetTerm().ToLower() == input);

            if (found != null)
            {
                lblDefinition.Text = found.GetDefinition();
                txtNewDef.Visible = false;
                btnAdd.Visible = false;
            }
            else
            {
                lblDefinition.Text = "I don't know that term yet. What does it mean?";
                txtNewDef.Visible = true;
                btnAdd.Visible = true;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (flashCards.Count >= MaxCards)
            {
                MessageBox.Show("You can't add more than 20 terms.");
                return;
            }
            string term = txtTerm.Text.Trim();
            string definition = txtNewDef.Text.Trim();

            if (!string.IsNullOrWhiteSpace(term) && !string.IsNullOrWhiteSpace(definition))
            {
                flashCards.Add(new FlashCard(term, definition));
                lblDefinition.Text = "Definition added";
                txtNewDef.Text = "";
                txtNewDef.Visible = false;
                btnAdd.Visible= false;
            }
        }
    }
}
