using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Final_Project
{
    public class Product
    {
        public string Name { get; }
        public decimal Price { get; }

        public Product(string name, decimal price)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name required");
            if (price < 0) throw new ArgumentException("Price must be >= 0");
            Name = name.Trim();
            Price = price;
        }

        public override string ToString() => $"{Name} - {Price:C}";
    }
}
