using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    public partial class Form1 : Form
    {
        private readonly List<SuperHero> _heroes = new List<SuperHero>();
        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            cboHero.SelectedIndexChanged += cboHero_SelectedIndexChanged;
            lnkWiki.LinkClicked += lnkWiki_LinkClicked;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _heroes.Add(new SuperHero
            {
                Name = "Iron Man",
                Likes = "Technology",
                Dislikes = "Captain America",
                Power = "Genius",
                Bio = "Tony Stark, billionaire inventor who built a powered suit to save his life and fight threats.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/e/e0/Iron_Man_bleeding_edge.jpg",
                WikiUrl = "https://en.wikipedia.org/wiki/Iron_Man"
            });

            _heroes.Add(new SuperHero
            {
                Name = "Captain America",
                Likes = "Justice",
                Dislikes = "Bullies",
                Power = "Peak human strength, shield skills",
                Bio = "Steve Rogers, a supersoldier from WWII known for leadership and unbreakable will.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/91/CaptainAmerica109.jpg",
                WikiUrl = "https://en.wikipedia.org/wiki/Captain_America"
            });

            _heroes.Add(new SuperHero
            {
                Name = "Spider-Man",
                Likes = "Science",
                Dislikes = "Symbiotes",
                Power = "Spider-sense, agility, wall-crawling",
                Bio = "Peter Parker balances being a student with saving New York as Spider-Man.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0c/Spiderman50.jpg",
                WikiUrl = "https://en.wikipedia.org/wiki/Spider-Man"
            });

            _heroes.Add(new SuperHero
            {
                Name = "Black Panther",
                Likes = "Wakanda",
                Dislikes = "Colonizers",
                Power = "Enhanced abilities, Vibranium tech",
                Bio = "T’Challa is the king of Wakanda, a nation of advanced technology and tradition.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/9/9f/Black_Panther_OS_Vol_1_1.png",
                WikiUrl = "https://en.wikipedia.org/wiki/Black_Panther_(character)"
            });

            _heroes.Add(new SuperHero
            {
                Name = "Wonder Woman",
                Likes = "Peace",
                Dislikes = "Injustice",
                Power = "Amazonian strength, lasso of truth",
                Bio = "Diana of Themyscira is a warrior for peace and a symbol of truth.",
                ImageUrl = "https://upload.wikimedia.org/wikipedia/en/0/0d/Wonder_Woman_%28DC_Rebirth_version%29.jpg",
                WikiUrl = "https://en.wikipedia.org/wiki/Wonder_Woman"
            });

            cboHero.Items.Clear();
            cboHero.Items.Add("(Select a hero)");
            foreach (var h in _heroes) cboHero.Items.Add(h);
            cboHero.SelectedIndex = 0;

            ClearDetails();
        }

        private void ClearDetails()
        {
            lblName.Text = "";
            lblLikes.Text = "";
            lblDislikes.Text = "";
            lblPower.Text = "";
            lblBio.Text = "";
            lnkWiki.Text = "";
            lnkWiki.Tag = null;
            picHero.ImageLocation = null;
            picHero.Image = null;
        }

        private void cboHero_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboHero.SelectedIndex <= 0)
            {
                ClearDetails();
                return;
            }

            var hero = cboHero.SelectedItem as SuperHero;
            if (hero == null) return;

            lblName.Text = hero.Name;
            lblLikes.Text = "Likes: " + hero.Likes;
            lblDislikes.Text = "Dislikes: " + hero.Dislikes;
            lblPower.Text = "Power: " + hero.Power;
            lblBio.Text = hero.Bio;

            lnkWiki.Text = hero.WikiUrl;
            lnkWiki.Tag = hero.WikiUrl;

            try
            {
                picHero.LoadAsync(hero.ImageUrl);
            }
            catch
            {
                picHero.ImageLocation = null;
                picHero.Image = null;
            }
        }

        private void lnkWiki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = lnkWiki.Tag as string;
            if (string.IsNullOrWhiteSpace(url)) return;

            try
            {
                Process.Start(url);
            }
            catch
            {
                try
                {
                    var psi = new ProcessStartInfo
                    {
                        FileName = url,
                        UseShellExecute = true
                    };
                    Process.Start(psi);
                }
                catch
                {
                    MessageBox.Show("Unable to open link.");
                }
            }
        }
    }
}
