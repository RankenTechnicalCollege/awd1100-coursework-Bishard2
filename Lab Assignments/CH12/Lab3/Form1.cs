using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        private List<Account> accounts = new List<Account>();
        private Account currentUser = null;
        public Form1()
        {
            InitializeComponent();
            LoadAccounts();
        }
        private void LoadAccounts()
        {
            accounts.Add(new Account("123-456-789", "1234", "Mr. A", 1000.00m));
            accounts.Add(new Account("234-567-899", "5678", "Ms. B", 2000.00m));
            accounts.Add(new Account("345-678-901", "9012", "Dr. C", 3000.00m));
            accounts.Add(new Account("456-789-012", "3456", "Mr. D", 4000.00m));
            accounts.Add(new Account("567-901-234", "7890", "Ms. E", 5000.00m));
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string accNum = txtAccount.Text.Trim();
            string pin = txtPIN.Text.Trim();

            Account found = accounts.FirstOrDefault(a => a.GetAccountNumber() == accNum && a.GetPin() == pin);

            if (found != null)
            {
                currentUser = found;
                lblWelcome.Text = $"Welcome {currentUser.GetName()}!";
                lblBalance.Text = $"Your account balance is {currentUser.GetBalance():C}";
                lblError.Text = "";
                ToggleLoginControls(false);
            }
            else
            {
                currentUser = null;
                lblWelcome.Text = "";
                lblBalance.Text = "";
                lblError.Text = "Invalid account or PIN.";
            }
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (currentUser != null && decimal.TryParse(txtDeposit.Text.Trim(), out decimal depositAmt))
            {
                currentUser.MakeDeposit(depositAmt);
                lblBalance.Text = $"Your account balance is {currentUser.GetBalance():C}";
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Invalid deposit amount.";
            }
        }
        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (currentUser != null && decimal.TryParse(txtWithdraw.Text.Trim(), out decimal withdrawAmt))
            {
                if (withdrawAmt > currentUser.GetBalance())
                {
                    lblError.Text = "Insufficient funds.";
                    return;
                }

                currentUser.MakeWithdrawal(withdrawAmt);
                lblBalance.Text = $"Your account balance is {currentUser.GetBalance():C}";
                lblError.Text = "";
            }
            else
            {
                lblError.Text = "Invalid withdrawal amount.";
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            currentUser = null;
            txtAccount.Text = "";
            txtPIN.Text = "";
            txtDeposit.Text = "";
            txtWithdraw.Text = "";
            lblWelcome.Text = "";
            lblBalance.Text = "";
            lblError.Text = "";
            ToggleLoginControls(true);
        }
        private void ToggleLoginControls(bool enable)
        {
            txtAccount.Enabled = enable;
            txtPIN.Enabled = enable;
            btnLogin.Enabled = enable;
            txtDeposit.Enabled = !enable;
            txtWithdraw.Enabled = !enable;
            btnDeposit.Enabled = !enable;
            btnWithdraw.Enabled = !enable;
            btnLogout.Enabled = !enable;
        }
    }
}