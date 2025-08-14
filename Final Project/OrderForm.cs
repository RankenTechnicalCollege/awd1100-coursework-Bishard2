using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class OrderForm : Form
    {
        private readonly List<Product> _products;
        private readonly Order _order;

        public Order Result => _order;

        public OrderForm(List<Product> products)
        {
            _products = products;
            _order = new Order("Customer");
            InitializeComponent();

            cboProduct.DataSource = _products.ToList();
            UpdateView();
        }

        private void UpdateView()
        {
            lstLines.DataSource = null;
            lstLines.DataSource = _order.Lines.Select(l => l.ToString()).ToList();
            lblTotal.Text = $"Total: {_order.Total:C}";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var p = cboProduct.SelectedItem as Product;
            if (p == null) return;
            int qty = (int)nudQty.Value;
            _order.AddLine(new OrderLine(p, qty));
            UpdateView();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_order.Lines.Count == 0)
            {
                MessageBox.Show("Add at least one line.");
                return;
            }

            _order.Lines.ToString();
            typeof(Order).GetProperty(nameof(Order.Customer))?
                .SetValue(_order, _order.Customer);

            var saved = new Order(string.IsNullOrWhiteSpace(txtCustomer.Text) ? "Customer" : txtCustomer.Text.Trim());
            foreach (var line in _order.Lines) saved.AddLine(line);

            typeof(OrderForm).GetField("_order", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
                             ?.SetValue(this, saved);

            DialogResult = DialogResult.OK;
        }
    }
}
