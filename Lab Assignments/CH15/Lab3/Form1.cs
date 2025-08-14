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
    public partial class Form1 : Form
    {
        private Random rnd = new Random();
        private List<ICard> boosterPack = new List<ICard>();
        private PictureBox[] pictures;
        private Label[] labels;
        public Form1()
        {
            InitializeComponent();
            pictures = new PictureBox[]
            {
                picCard1, picCard2, picCard3, picCard4, picCard5,
                picCard6, picCard7, picCard8, picCard9, picCard10
            };

            labels = new Label[]
            {
                lblCard1, lblCard2, lblCard3, lblCard4, lblCard5,
                lblCard6, lblCard7, lblCard8, lblCard9, lblCard10
            };
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            boosterPack.Clear();

            for (int i = 0; i < 10; i++)
            {
                string name = GetRandomPokemonName();
                bool isShiny = rnd.NextDouble() < 0.2;

                string imageName = isShiny ? $"Shiny{name}" : name;
                Image img = GetPokemonImage(imageName);
                double value = rnd.Next(100, 1000) / 10.0;

                ICard card;
                if (isShiny)
                {
                    card = new ShinyCard(name, img, value, Color.Gold, Color.Green);
                }
                else
                {
                    card = new NormalCard(name, img, value);
                }

                boosterPack.Add(card);
            }

            boosterPack.Sort((a, b) =>
            {
                bool aShiny = a is ShinyCard;
                bool bShiny = b is ShinyCard;

                if (aShiny != bShiny)
                    return aShiny ? 1 : -1;

                if (a is IComparable ia) return ia.CompareTo(b);
                return 0;
            });

            for (int i = 0; i < 10; i++)
            {
                boosterPack[i].ShowCard(pictures[i], labels[i]);
            }
        }

        private string GetRandomPokemonName()
        {
            string[] names = {
                "Bulbasaur", "Charmander", "Squirtle", "Caterpie",
                "Weedle", "Pidgey", "Rattata", "Ekans"
            };
            return names[rnd.Next(names.Length)];
        }

        private Image GetPokemonImage(string name)
        {
            return Properties.Resources.ResourceManager.GetObject(name) as Image;
        }
    }
 }
