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
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            try
            {
                short itemNumber = short.Parse(txtItemNumber.Text);
                byte quantity = byte.Parse(txtQuantity.Text);
                byte deliveryDays = byte.Parse(txtDeliveryDays.Text);

                Order order = new Order(itemNumber, quantity, deliveryDays);
                lblOutput.ForeColor = System.Drawing.Color.Black;
                lblOutput.Text = "Order is valid";
            }
            catch (FormatException)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Invalid input format";
            }
            catch (InvalidItemNumberException)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Invalid Item Number";
            }
            catch (InvalidQuantityException)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Invalid Quantity";
            }
            catch (InvalidDeliveryDaysException)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Invalid Delivery Days";
            }
        }
    }
}
