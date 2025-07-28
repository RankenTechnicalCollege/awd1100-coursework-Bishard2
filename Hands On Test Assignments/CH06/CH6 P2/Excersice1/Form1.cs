using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excersice1
{
    public partial class Form1 : Form
    {
        private const decimal PRICE_SMALL = 9.99m;
        private const decimal PRICE_MEDIUM = 10.99m;
        private const decimal PRICE_LARGE = 11.99m;
        private const decimal TAX_RATE = 0.07m;
        private int _smallCount = 0;
        private int _mediumCount = 0;
        private int _largeCount = 0;

        private readonly List<(string Size, decimal Price)> _order
          = new List<(string Size, decimal Price)>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddShirt("Small");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddShirt("Medium");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddShirt("Large");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearOrder();
            ShowInvoice();
        }
        private void AddShirt(string size)
        {
            decimal price;

            if (size == "Small")
                price = PRICE_SMALL;
            else if (size == "Medium")
                price = PRICE_MEDIUM;
            else if (size == "Large")
                price = PRICE_LARGE;
            else
                price = 0m;

            switch (size)
            {
                case "Small": _smallCount++; break;
                case "Medium": _mediumCount++; break;
                case "Large": _largeCount++; break;
            }
            _order.Add((size, price));
            ShowInvoice();
        }
        private void ClearOrder()
        {
            _order.Clear();
            listBox.Items.Clear();

            _smallCount = 0;
            _mediumCount = 0;
            _largeCount = 0;

            lblSmallCount.Text = "$Small: 0";
            lblMediumCount.Text = "$Medium: 0";
            lblLargeCount.Text = "$Large: 0";

            lblSubtotal.Text = "Subtotal: $0.00";
            lblTax.Text = "Tax: $0.00";
            lblTotal.Text = "Total: $0.00";
        }
        private void ShowInvoice()
        {
            listBox.Items.Clear();
            int idx = 1;
            foreach (var item in _order)
                listBox.Items.Add($"{idx++}. {item.Size} @ {item.Price:C2}");

            lblSmallCount.Text = $"Small:  {_smallCount}";
            lblMediumCount.Text = $"Medium: {_mediumCount}";
            lblLargeCount.Text = $"Large:  {_largeCount}";

            decimal subtotal = _order.Sum(x => x.Price);
            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tax;

            lblSubtotal.Text = "Subtotal: " + subtotal.ToString("C2");
            lblTax.Text = "Tax: " + tax.ToString("C2");
            lblTotal.Text = "Total: " + total.ToString("C2");
        }
    }
}
