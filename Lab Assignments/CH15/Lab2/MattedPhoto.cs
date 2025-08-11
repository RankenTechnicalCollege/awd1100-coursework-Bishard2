using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class MattedPhoto : Photo
    {
        private Color color;

        public MattedPhoto(float width, float height, Color color) : base(width, height)
        {
            this.color = color;
        }

        public Color Color { get => color; set => color = value; }

        public override float Price => base.Price + 10.0f;

        public override string ToString()
        {
            return $"{width}x{height} MattedPhoto ({color}) - ${Price:F2}";
        }
    }
}
