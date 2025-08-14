using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class MainForm : Form
    {
        private readonly List<Product> _products = new List<Product>();
        private readonly List<Order> _orders = new List<Order>();
        public MainForm()
        {
            InitializeComponent();
        }
        private void RefreshProducts()
        {
            lstProducts.DataSource = null;
            lstProducts.DataSource = _products;
        }

        private void RefreshOrders()
        {
            lstOrders.DataSource = null;
            lstOrders.DataSource = _orders;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var name = txtName.Text.Trim();
                if (!decimal.TryParse(txtPrice.Text, NumberStyles.Number, CultureInfo.CurrentCulture, out var price))
                    throw new FormatException("Enter a valid price.");

                _products.Add(new Product(name, price));
                RefreshProducts();

                txtName.Clear();
                txtPrice.Clear();
                txtName.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Product", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            if (_products.Count == 0)
            {
                MessageBox.Show("Add at least one product first.");
                return;
            }

            using (var dlg = new OrderForm(_products))
                if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _orders.Add(dlg.Result);
                RefreshOrders();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
