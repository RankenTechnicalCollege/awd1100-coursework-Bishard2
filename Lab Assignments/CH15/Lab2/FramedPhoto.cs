using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class FramedPhoto : Photo
    {
        private Material material;
        private Style style;

        public FramedPhoto(float width, float height, Material material, Style style) : base(width, height)
        {
            this.material = material;
            this.style = style;
        }

        public Material Material { get => material; set => material = value; }
        public Style Style { get => style; set => style = value; }

        public override float Price => base.Price + 25.0f;

        public override string ToString()
        {
            return $"{width}x{height} FramedPhoto ({material}, {style}) - ${Price:F2}";
        }
    }
}
