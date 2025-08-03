using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab1
{
    public enum SundaeTopping { NONE, SPRINKLES, NUTS, CHOCOLATE_SYRUP }
    public enum SodaFlavor { NONE, LIME, PEACH, MANGO }
    public partial class Form1 : Form
    {
        private List<Order> orders = new List<Order>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                lblError.Text = "Name required / No food selected";
                return;
            }

            lblError.Text = "";

            bool hasSundae = cbSundae.Checked;
            bool hasSoda = cbSoda.Checked;

            if (!hasSundae && !hasSoda)
            {
                lblError.Text = "No food selected";
                return;
            }

            Order order = new Order(name, hasSundae, hasSoda);

            if (hasSundae)
            {
                int toppingCount = 0;
                if (cbSprinkles.Checked && toppingCount < 2) { order.Sundae.AddTopping(SundaeTopping.SPRINKLES); toppingCount++; }
                if (cbNuts.Checked && toppingCount < 2) { order.Sundae.AddTopping(SundaeTopping.NUTS); toppingCount++; }
                if (cbChocolate.Checked && toppingCount < 2) { order.Sundae.AddTopping(SundaeTopping.CHOCOLATE_SYRUP); toppingCount++; }
            }

            if (hasSoda)
            {
                if (rdLime.Checked) order.Soda.AddFlavor(SodaFlavor.LIME);
                else if (rdPeach.Checked) order.Soda.AddFlavor(SodaFlavor.PEACH);
                else if (rdMango.Checked) order.Soda.AddFlavor(SodaFlavor.MANGO);
            }

            orders.Add(order);
            lstOrders.Items.Add(order.Name);
            if (order.Sundae != null)
                lstOrders.Items.Add($"Sundae - {order.Sundae} - {order.Sundae.Price:F2}");
            if (order.Soda != null)
                lstOrders.Items.Add($"Soda - {order.Soda} - {order.Soda.Price:F2}");
            lstOrders.Items.Add("--------------------------");

            UpdateTotal();
            ClearForm();
        }
        private void UpdateTotal()
        {
            double total = orders.Sum(o => o.Price);
            lblTotal.Text = $"Total: ${total:F2}";
        }

        private void ClearForm()
        {
            txtName.Clear();
            cbSundae.Checked = false;
            cbSoda.Checked = false;

            cbSprinkles.Checked = false;
            cbNuts.Checked = false;
            cbChocolate.Checked = false;

            rdLime.Checked = false;
            rdPeach.Checked = false;
            rdMango.Checked = false;
        }
    }
}
