using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        private List<Account> accounts = new List<Account>();
        private Account loggedInAccount = null;

        public Form1()
        {
            InitializeComponent();
            InitializeAccounts();
        }
        private void InitializeAccounts()
        {
            accounts.Add(new BronzeAccount("123-456-789", "1234", "Mr. Smith", 500));
            accounts.Add(new SilverAccount("234-567-890", "2345", "Ms. Doe", 1500));
            accounts.Add(new GoldAccount("345-678-901", "3456", "Mr. Gold", 6000));
            accounts.Add(new BronzeAccount("456-789-012", "4567", "Ms. Bronze", 100));
            accounts.Add(new SilverAccount("567-890-123", "5678", "Mr. Silver", 2000));
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string acc = txtAccount.Text;
            string pin = txtPin.Text;

            foreach (var acct in accounts)
            {
                if (acct.AccountNumber == acc && acct.Pin == pin)
                {
                    loggedInAccount = acct;
                    lblWelcome.Text = $"Welcome {acct.Owner}!\nYour account balance is ${acct.Balance:N2}\nAccount Type: {acct.GetType().Name}";
                    return;
                }
            }

            MessageBox.Show("Invalid login details");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (loggedInAccount == null) return;
            if (double.TryParse(txtDeposit.Text, out double amount))
            {
                loggedInAccount.Deposit(amount);
                lblWelcome.Text = $"Welcome {loggedInAccount.Owner}!\nYour account balance is ${loggedInAccount.Balance:N2}\nAccount Type: {loggedInAccount.GetType().Name}";
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (loggedInAccount == null) return;
            if (double.TryParse(txtWithdraw.Text, out double amount))
            {
                if (!loggedInAccount.Withdraw(amount))
                {
                    MessageBox.Show("Cannot withdraw: Minimum balance would be breached or insufficient funds.");
                }
                lblWelcome.Text = $"Welcome {loggedInAccount.Owner}!\nYour account balance is ${loggedInAccount.Balance:N2}\nAccount Type: {loggedInAccount.GetType().Name}";
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (loggedInAccount is SilverAccount || loggedInAccount is GoldAccount)
            {
                string transactions = string.Join("\n", loggedInAccount.GetLastTransactions());
                MessageBox.Show(transactions, "Statement");
            }
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            loggedInAccount = null;
            lblWelcome.Text = "Logged out.";
        }
        public class Account
        {
            public string AccountNumber { get; }
            public string Pin { get; }
            public string Owner { get; }
            public double Balance { get; protected set; }
            protected List<string> Transactions = new List<string>();
            protected virtual double MinimumBalance => 0;

            public Account(string acc, string pin, string owner, double balance)
            {
                AccountNumber = acc;
                Pin = pin;
                Owner = owner;
                Balance = balance;
            }

            public virtual void Deposit(double amount)
            {
                Balance += amount;
                Transactions.Add($"CREDIT ${amount:N2}");
            }

            public virtual bool Withdraw(double amount)
            {
                double fee = 0.01 * amount;
                if (Balance - amount - fee >= MinimumBalance)
                {
                    Balance -= (amount + fee);
                    Transactions.Add($"DEBIT ${amount:N2}");
                    return true;
                }
                return false;
            }

            public virtual List<string> GetLastTransactions()
            {
                return new List<string>(Transactions.GetRange(Math.Max(0, Transactions.Count - 10), Math.Min(10, Transactions.Count)));
            }
        }

        public class BronzeAccount : Account
        {
            public BronzeAccount(string acc, string pin, string owner, double balance) : base(acc, pin, owner, balance) { }
        }

        public class SilverAccount : Account
        {
            protected override double MinimumBalance => 1000;
            public SilverAccount(string acc, string pin, string owner, double balance) : base(acc, pin, owner, balance) { }
        }

        public class GoldAccount : SilverAccount
        {
            protected override double MinimumBalance => 5000;

            public GoldAccount(string acc, string pin, string owner, double balance) : base(acc, pin, owner, balance) { }

            public override bool Withdraw(double amount)
            {
                if (Balance - amount >= MinimumBalance)
                {
                    Balance -= amount;
                    Transactions.Add($"DEBIT ${amount:N2}");
                    return true;
                }
                return false;
            }
        }
    }
}
