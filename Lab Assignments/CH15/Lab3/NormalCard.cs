using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public class NormalCard : ICard
    {
        public string Name { get; }
        public Image Image { get; }
        public double Value { get; }

        public NormalCard(string name, Image image, double value)
        {
            Name = name;
            Image = image;
            Value = value;
        }

        public void ShowCard(PictureBox picture, Label label)
        {
            picture.Image = Image;
            label.Text = $"{Name}\n${Value:F2}";
            label.ForeColor = Color.Black;
            label.Font = new Font("Arial", 10, FontStyle.Regular);
        }

        public int CompareTo(ICard other) => other.Value.CompareTo(Value);
    }
}
