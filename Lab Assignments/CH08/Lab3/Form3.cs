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
        private readonly string[] _names = {
            "Player Unknown's Battlegrounds (PUBG)",
            "League of Legends",
            "Call of Duty: Black Ops III",
            "Battlefield 4",
            "Super Mario Odyssey"
        };
        private readonly string[] _publishers = {
            "Bluehole",
            "Riot Games",
            "Activision",
            "Electronic Arts (EA)",
            "Nintendo"
        };
        private readonly decimal[] _prices = {
            35m, 0m, 60m, 20m, 60m
        };
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblName.Text = "";
            lblPublisher.Text = "";
            lblPrice.Text = "";

            string query = txtSearch.Text.Trim().ToLower();
            if (query == "")
            {
                MessageBox.Show("Please enter a name or publisher to search for.",
                                "No Search Term", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int idx = Array.FindIndex(_names,
                      name => name.ToLower().Contains(query)
                    || _publishers[Array.IndexOf(_names, name)]
                                .ToLower().Contains(query)
            );
            if (idx < 0)
            {
                lblName.Text = "Game Not Found";
                lblPublisher.Text = "Game Not Found";
                lblPrice.Text = "Game Not Found";
            }
            else
            {
                lblName.Text = _names[idx];
                lblPublisher.Text = _publishers[idx];
                lblPrice.Text = _prices[idx].ToString("C");
            }
        }
    }
}
