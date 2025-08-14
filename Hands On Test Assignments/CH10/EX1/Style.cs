using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace EX1
{
    public class Style
    {
        public string Name { get; }
        public decimal BasePrice { get; }
        public Image Art { get; }

        public Style(string name, decimal basePrice, Image art = null)
        {
            Name = name ?? "Style";
            BasePrice = basePrice;
            Art = art;
        }

        public override string ToString() => string.Format("{0} (${1:0.00})", Name, BasePrice);
    }
}
