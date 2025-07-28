using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excercise2
{
    public partial class Form2 : Form
    {
        private const decimal PRICE_PER_SHIRT = 13.75m;
        private const decimal TAX_RATE = 0.08m;
        private readonly Dictionary<string, decimal> _discounts =
        new Dictionary<string, decimal>
        {
            ["8264"] = 0.30m,
            ["5679"] = 0.20m,
            ["6483"] = 0.10m
        };
        public Form2()
        {
            InitializeComponent();
            lblError.Visible = false;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                lblError.Text = "* Quantity must be a positive whole number";
                lblError.Visible = true;
                return;
            }

            string code = txtDiscountCode.Text.Trim();
            decimal discountPct = CheckDiscountCode(code);

            if (discountPct == 0m && code.Length > 0)
            {
                lblError.Text = "* Invalid discount code";
                lblError.Visible = true;
            }
            else if (discountPct > 0m)
            {
                lblError.Text = $"✔ Discount code applied: {discountPct:P0}";
                lblError.Visible = true;
            }
            else
            {
                lblError.Visible = false;
            }
            ShowInvoice(quantity, (float)discountPct);
        }

        private decimal CheckDiscountCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
                return 0m;

            foreach (var kv in _discounts)
            {
                if (kv.Key == code)
                    return kv.Value;
            }

            return 0m;
        }

        private void ShowInvoice(int quantity, float discountPercentage)
        {
            decimal originalPrice = PRICE_PER_SHIRT;
            decimal discountAmount = originalPrice * (decimal)discountPercentage;
            decimal discountedPrice = originalPrice - discountAmount;

            decimal subtotal = discountedPrice * quantity;
            decimal tax = subtotal * TAX_RATE;
            decimal total = subtotal + tax;

            lblInvoice.Text =
                $"{quantity} T-Shirts @ {originalPrice:C2} each\r\n" +
                (discountPercentage > 0
                    ? $"Discount Applied: {discountPercentage:P0} (-{discountAmount:C2} each)\r\n"
                    : "") +
                $"Subtotal: {subtotal:C2}\r\n" +
                $"Tax: {tax:C2}\r\n" +
                $"Total: {total:C2}";
        }
    }
}

