using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form7 : Form
    {
        List<string> _acctNums = new List<string> { "123-456-789", "987-654-321" };
        List<string> _pins = new List<string> { "1234", "4321" };
        List<decimal> _balances = new List<decimal> { 10000m, 2500m };
        int _currentIndex = -1;
        public Form7()
        {
            InitializeComponent();
            UpdateUI();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login(txtAccount.Text.Trim(), txtPIN.Text.Trim());
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (_currentIndex >= 0 && decimal.TryParse(txtDeposit.Text, out var amt))
                MakeDeposit(amt);
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            if (_currentIndex >= 0 && decimal.TryParse(txtWithdrawal.Text, out var amt))
                MakeWithdrawl(amt);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Logout();
        }
        private void Login(string accountNum, string pin)
        {
            if (_currentIndex >= 0)
                Logout();

            int idx = _acctNums.IndexOf(accountNum);
            if (idx >= 0 && _pins[idx] == pin)
            {
                _currentIndex = idx;
                lblWelcome.Text = $"Welcome, account {accountNum}!\nBalance: {_balances[idx]:C}";
            }
            else
            {
                lblWelcome.Text = "Invalid account or PIN";
                _currentIndex = -1;
            }
            UpdateUI();
        }
        private void Logout()
        {
            _currentIndex = -1;
            lblWelcome.Text = "Please log in.";
            UpdateUI();
        }
        private void MakeDeposit(decimal depositAmount)
        {
            _balances[_currentIndex] += depositAmount;
            lblWelcome.Text = $"Deposited {depositAmount:C}\nBalance: {_balances[_currentIndex]:C}";
        }
        private void MakeWithdrawl(decimal withdrawAmount)
        {
            if (withdrawAmount <= _balances[_currentIndex])
            {
                _balances[_currentIndex] -= withdrawAmount;
                lblWelcome.Text = $"Withdrew {withdrawAmount:C}\nBalance: {_balances[_currentIndex]:C}";
            }
            else
            {
                lblWelcome.Text = "Insufficient funds";
            }
        }
        private void UpdateUI()
        {
            bool loggedIn = _currentIndex >= 0;

            txtAccount.Enabled = !loggedIn;
            txtPIN.Enabled = !loggedIn;
            btnLogin.Enabled = !loggedIn;

            btnLogout.Enabled = loggedIn;

            txtDeposit.Enabled = loggedIn;
            btnDeposit.Enabled = loggedIn;
            txtWithdrawal.Enabled = loggedIn;
            btnWithdrawal.Enabled = loggedIn;
        }
    }
}
