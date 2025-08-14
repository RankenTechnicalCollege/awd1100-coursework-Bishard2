using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    public class Order
    {
        public string Customer { get; set; } = "";
        public List<OrderLine> Lines { get; } = new List<OrderLine>();

        public Order(string customer)
        {
            Customer = string.IsNullOrWhiteSpace(customer) ? "Customer" : customer.Trim();
        }

        public void AddLine(OrderLine line) => Lines.Add(line);

        public decimal Total => Lines.Sum(l => l.LineTotal);

        public override string ToString() => $"{Customer} — {Lines.Count} item(s), Total {Total:C}";
    }
}
