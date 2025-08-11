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

namespace Lab3
{
    public partial class Form1 : Form
    {
        private List<Account> accounts;
        public Form1()
        {
            InitializeComponent();

            accounts = new List<Account>
            {
                new Account("prsmith", "pass123", "Paul", false),
                new Account("jdoe", "doe456", "Jane", false),
                new Account("asmith", "abc789", "Anna", true),
                new Account("bwayne", "dark123", "Bruce", false),
                new Account("ckent", "super1", "Clark", false)
            };
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();

                Account acc = Login(username, password);
                lblOutput.ForeColor = System.Drawing.Color.Black;
                lblOutput.Text = $"Welcome {acc.FirstName}!";
            }
            catch (NoUsernamePasswordException)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "You must enter a username and password";
            }
            catch (IncorrectPasswordException)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Incorrect Username/Password";
            }
            catch (AccountDisabledException)
            {
                lblOutput.ForeColor = System.Drawing.Color.Red;
                lblOutput.Text = "Account Disabled";
            }
        }
             private Account Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new NoUsernamePasswordException();

            foreach (Account acc in accounts)
            {
                if (acc.Username == username && acc.Password == password)
                {
                    if (acc.IsDisabled)
                        throw new AccountDisabledException();
                    return acc;
                }
            }
            throw new IncorrectPasswordException();
        }
    }
}
