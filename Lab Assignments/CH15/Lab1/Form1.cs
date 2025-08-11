using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CH14_15
{
    public partial class Form1 : Form
    {
        private List<Letter> sentLetters = new List<Letter>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (sentLetters.Count >= 20)
            {
                MessageBox.Show("You cannot send more than 20 letters.");
                return;
            }

            string recipient = txtRecipient.Text;
            if (!DateTime.TryParse(txtDate.Text, out DateTime sentDate))
            {
                MessageBox.Show("Enter a valid date.");
                return;
            }

            string tracking = txtTrackingNumber.Text.Trim();
            Letter letter;
            if (string.IsNullOrWhiteSpace(tracking))
            {
                letter = new Letter(recipient, sentDate);
            }
            else
            {
                letter = new CertifiedLetter(recipient, sentDate, tracking);
            }

            sentLetters.Insert(0, letter);
            UpdateTransactionLog();
        }
        private void UpdateTransactionLog()
        {
            lstLog.Items.Clear();
            foreach (var letter in sentLetters)
            {
                lstLog.Items.Add(letter.ToString());
            }
        }
    }
}
