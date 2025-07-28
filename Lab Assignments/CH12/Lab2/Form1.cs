using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        private List<InventoryItem> inventory = new List<InventoryItem>();
        private string accessKey = "1234";
        private const int MaxItems = 20;
        public Form1()
        {
            InitializeComponent();
            LoadInitialInventory();
        }
        private void LoadInitialInventory()
        {
            inventory.Add(new InventoryItem("Bottle Rocket", 12345678, 15.00m, 100.00m, 50, "Black Cat"));
            inventory.Add(new InventoryItem("Firecracker", 23456789, 5.00m, 60.00m, 30, "Thunder Boom"));
            inventory.Add(new InventoryItem("Roman Candle", 34567890, 12.00m, 90.00m, 40, "Sky Blaster"));
            inventory.Add(new InventoryItem("Sparklers", 45678901, 2.50m, 30.00m, 25, "Glow Inc"));
            inventory.Add(new InventoryItem("Smoke Bomb", 56789012, 3.50m, 35.00m, 20, "Smoke Bros"));
        }
        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            string name = txtSearchName.Text.Trim().ToLower();
            InventoryItem found = inventory.FirstOrDefault(i => i.getItemName().ToLower() == name);

            if (found != null)
            {
                DisplayItem(found);
            }
            else
            {
                lblStatus.Text = "Item not found by name.";
            }
        }
        private void btnSearchUPC_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearchUPC.Text.Trim(), out int upc))
            {
                InventoryItem found = inventory.FirstOrDefault(i => i.getUpc() == upc);

                if (found != null)
                {
                    DisplayItem(found);
                }
                else
                {
                    lblStatus.Text = "Item not found by UPC.";
                }
            }
            else
            {
                lblStatus.Text = "Invalid UPC.";
            }
        }

        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (txtAccessKeyUpdate.Text != accessKey)
            {
                lblStatus.Text = "Access Key Incorrect";
                return;
            }

            if (int.TryParse(txtSearchUPC.Text.Trim(), out int upc) &&
                decimal.TryParse(txtNewPrice.Text.Trim(), out decimal newPrice))
            {
                InventoryItem found = inventory.FirstOrDefault(i => i.getUpc() == upc);

                if (found != null)
                {
                    found.setPrice(newPrice);
                    lblStatus.Text = "Price updated successfully.";
                }
                else
                {
                    lblStatus.Text = "Item not found.";
                }
            }
            else
            {
                lblStatus.Text = "Invalid input.";
            }
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            if (txtAccessKeyDelete.Text != accessKey)
            {
                lblStatus.Text = "Access Key Incorrect";
                return;
            }

            if (int.TryParse(txtDeleteUPC.Text.Trim(), out int upc))
            {
                InventoryItem found = inventory.FirstOrDefault(i => i.getUpc() == upc);
                if (found != null)
                {
                    inventory.Remove(found);
                    lblStatus.Text = "Item deleted.";
                }
                else
                {
                    lblStatus.Text = "Item not found.";
                }
            }
            else
            {
                lblStatus.Text = "Invalid UPC.";
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (txtNewAccessKey.Text != accessKey)
            {
                lblStatus.Text = "Access Key Incorrect";
                return;
            }

            if (inventory.Count >= MaxItems)
            {
                lblStatus.Text = "Inventory full.";
                return;
            }

            if (int.TryParse(txtNewUPC.Text.Trim(), out int upc) &&
                decimal.TryParse(txtNewPrice.Text.Trim(), out decimal price) &&
                decimal.TryParse(txtNewCostPerCase.Text.Trim(), out decimal costPerCase) &&
                int.TryParse(txtNewUnitsPerCase.Text.Trim(), out int unitsPerCase))
            {
                if (inventory.Any(i => i.getUpc() == upc))
                {
                    lblStatus.Text = "UPC already exists.";
                    return;
                }

                string name = txtNewName.Text.Trim();
                string distributor = txtNewDistributor.Text.Trim();
                inventory.Add(new InventoryItem(name, upc, price, costPerCase, unitsPerCase,distributor));
                lblStatus.Text = "Item added.";
            }
            else
            {
                lblStatus.Text = "Invalid input for new item.";
            }
        }

        private void DisplayItem(InventoryItem item)
        {
            lblName.Text = "Name: " + item.getItemName();
            lblUPC.Text = "UPC: " + item.getUpc().ToString();
            lblPrice.Text = "Store Price: $" + item.getPrice().ToString("0.00");
            lblCostPerCase.Text = "Cost Per Case: $" + item.getCostPerCase().ToString("0.00");
            lblUnitsPerCase.Text = "Units Per Case: " + item.getUnitsPerCase();
            lblDistributor.Text = "Distributor: " + item.getDistributor();
        }
    }
}
