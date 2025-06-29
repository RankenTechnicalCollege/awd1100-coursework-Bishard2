using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form4 : Form
    {
        private readonly string[] _titles = {
            "Lord of the Rings: Fellowship of the Ring",
            "Inception",
            "The Matrix",
            "Parasite",
            "Spirited Away"
        };
        private readonly string[] _directors = {
            "Peter Jackson",
            "Christopher Nolan",
            "The Wachowskis",
            "Bong Joon-ho",
            "Hayao Miyazaki"
        };
        private readonly string[] _descriptions = {
            "An epic journey of hobbits and magic rings.",
            "A thief who enters dreams to steal secrets.",
            "A hacker learns reality is a simulation.",
            "A poor family infiltrates a wealthy one.",
            "A young girl enters a world of spirits."
        };
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lblName.Text = lblDirector.Text = lblDescription.Text = "";

            var query = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(query))
            {
                MessageBox.Show(
                    "Please enter a movie title or director to search for.",
                    "Input Required",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }
            int idx = Array.FindIndex(_titles, t =>
                       t.ToLower().Contains(query)
                    || _directors[Array.IndexOf(_titles, t)]
                                .ToLower().Contains(query)
            );
            if (idx < 0)
            {
                lblName.Text = "Movie Not Found";
                lblDirector.Text = "Movie Not Found";
                lblDescription.Text = "Movie Not Found";
            }
            else
            {
                lblName.Text = _titles[idx];
                lblDirector.Text = _directors[idx];
                lblDescription.Text = _descriptions[idx];
            }
        }
    }
}
