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
        }

        private void btnBid_Click(object sender, EventArgs e)
        {
            string input = txtBid.Text;

            string message = ParseBid(input);

            lblMessage.Text = message;
        }
        public string ParseBid(string bidString)
        {
            if (string.IsNullOrWhiteSpace(bidString))
                return "Invalid Bid";

            var s = bidString.Trim().ToLowerInvariant();

            if (s.StartsWith("$"))
                s = s.Substring(1).Trim();

            if (s.EndsWith("dollars"))
                s = s.Substring(0, s.Length - "dollars".Length).Trim();

            if (!decimal.TryParse(s, out decimal value))
                return "Invalid Bid";

            if (value < 10m)
                return "Bid must be at least $10";

            return $"Bid of {value:C2} accepted!";
        }
    }
}
