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

namespace Lab4
{
    public partial class Form1 : Form
    {
        private decimal totalDanielle = 0m;
        private decimal totalEdward = 0m;
        private decimal totalFrancis = 0m;
        public Form1()
        {
            InitializeComponent();
            UpdateAllLabels();
        }
        private void btnDanielle_Click(object sender, EventArgs e)
        {
            HandleSale('d');
        }
        private void btnEdward_Click(object sender, EventArgs e)
        {
            HandleSale('e');
        }
        private void btnFrancis_Click(object sender, EventArgs e)
        {
            HandleSale('f');
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            totalDanielle = 0m;
            totalEdward = 0m;
            totalFrancis = 0m;
            UpdateAllLabels();
            txtSaleAmount.Clear();
            txtSaleAmount.Focus();
        }
        private void HandleSale(char initial)
        {
            string text = txtSaleAmount.Text.Trim();
            if (!decimal.TryParse(text, NumberStyles.Number, CultureInfo.InvariantCulture, out decimal amount)
                || amount < 0m)
            {
                MessageBox.Show(
                    "Invalid sale amount. Please enter a non-negative number, e.g. 1000.00",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                txtSaleAmount.SelectAll();
                txtSaleAmount.Focus();
                return;
            }
            switch (char.ToLowerInvariant(initial))
            {
                case 'd':
                    totalDanielle += amount;
                    break;
                case 'e':
                    totalEdward += amount;
                    break;
                case 'f':
                    totalFrancis += amount;
                    break;
                default:
                    MessageBox.Show("Internal error: invalid salesperson initial.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            UpdateAllLabels();
            txtSaleAmount.Clear();
            txtSaleAmount.Focus();
        }
        private void UpdateAllLabels()
        {
            lblDanielleSales.Text = $"Danielle Sales: {totalDanielle.ToString("C2")}";
            lblEdwardSales.Text = $"Edward Sales:   {totalEdward.ToString("C2")}";
            lblFrancisSales.Text = $"Francis Sales:  {totalFrancis.ToString("C2")}";

            decimal grand = totalDanielle + totalEdward + totalFrancis;
            lblGrandTotal.Text = $"Grand Total:    {grand.ToString("C2")}";

            string topName = "Danielle";
            decimal topAmount = totalDanielle;
            if (totalEdward > topAmount)
            {
                topAmount = totalEdward;
                topName = "Edward";
            }
            if (totalFrancis > topAmount)
            {
                topAmount = totalFrancis;
                topName = "Francis";
            }
            lblTopSalesperson.Text = $"{topName} has the most sales";
        }
    }
}
