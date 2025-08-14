using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class OrderLine
    {
        public Product Product { get; }
        public int Quantity { get; }

        public OrderLine(Product product, int quantity)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (quantity <= 0) throw new ArgumentException("Quantity must be > 0");
            Product = product;
            Quantity = quantity;
        }

        public decimal LineTotal => Product.Price * Quantity;
        public override string ToString() => $"{Product.Name} x{Quantity} = {LineTotal:C}";
    }
}
