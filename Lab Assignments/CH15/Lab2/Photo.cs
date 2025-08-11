using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Photo
    {
        protected float width;
        protected float height;

        public Photo(float width, float height)
        {
            this.width = width;
            this.height = height;
        }

        public float Width { get => width; set => width = value; }
        public float Height { get => height; set => height = value; }

        public virtual float Price
        {
            get
            {
                if (width == 8 && height == 10) return 3.99f;
                if (width == 10 && height == 12) return 5.99f;
                return 9.99f;
            }
        }

        public override string ToString()
        {
            return $"{width}x{height} Unframed Photo - ${Price:F2}";
        }
    }
}
