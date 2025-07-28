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
    public partial class Form1 : Form
    {
        private List<Game> games = new List<Game>();
        public Form1()
        {
            InitializeComponent();
            LoadGames();
        }
        private void LoadGames()
        {
            games.Add(new Game("Player Unknown's Battlegrounds (PUBG)", "Bluehole", 35f));
            games.Add(new Game("League of Legends", "Riot Games", 0f));
            games.Add(new Game("Call of Duty: Black Ops III", "Activision", 60f));
            games.Add(new Game("Battlefield 4", "Electronic Arts (EA)", 20f));
            games.Add(new Game("Super Mario Odyssey", "Nintendo", 60f));
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int index = SearchForGame(txtName.Text.Trim().ToLower());
            ShowGameInfo(index);
        }
        private int SearchForGame(string query)
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].GetName().ToLower().Contains(query) || games[i].GetPublisher().ToLower().Contains(query))
                {
                    return i;
                }
            }
            return -1;
        }
        private void ShowGameInfo(int index)
        {
            if (index >= 0 && index < games.Count)
            {
                lblName.Text = "Name: " + games[index].GetName();
                lblPublisher.Text = "Publisher: " + games[index].GetPublisher();
                lblPrice.Text = "Price: $" + games[index].GetPrice().ToString("0.00");
            }
            else
            {
                lblName.Text = "Name: Game Not Found";
                lblPublisher.Text = "Publisher: Game Not Found";
                lblPrice.Text = "Price: Game Not Found";
            }
        }
    }
}
