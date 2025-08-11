using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public class ShinyCard : ICard
    {
        public string Name { get; }
        public Image Image { get; }
        public double Value { get; }
        private Font font;
        private Color foreColor;
        private Color backColor;

        public ShinyCard(string name, Image image, double value, Color foreColor, Color backColor)
        {
            Name = name;
            Image = image;
            Value = value;
            this.foreColor = foreColor;
            this.backColor = backColor;
        }

        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = Image;
            label.Text = $"Shiny {Name}!\n${Value:F2}";
            label.Font = font;
            label.ForeColor = foreColor;
            label.BackColor = backColor;
        }

        public int CompareTo(ICard other) => other.Value.CompareTo(Value);
    }
}
