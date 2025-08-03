using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {
        private ILoan currentLoan;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreateLoan_Click(object sender, EventArgs e)
    {
        lblResult.Text = "";
        string name = txtName.Text;
        if (!double.TryParse(txtAmount.Text, out double amount) || amount < 0)
        {
            MessageBox.Show("Enter a valid positive loan amount.");
            return;
        }

        if (rbShortTerm.Checked)
        {
            currentLoan = new ShortTermLoan(name, amount);
        }
        else if (rbLongTerm.Checked)
        {
            currentLoan = new LongTermLoan(name, amount);
        }
        else
        {
            MessageBox.Show("Select a loan type.");
            return;
        }

        lblResult.Text = $"Loan Created:\nName: {currentLoan.Name}\nType: {currentLoan.Type}\nAmount: {currentLoan.Balance:C}";
    }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            if (currentLoan == null)
            {
                MessageBox.Show("No loan has been created.");
                return;
            }

            currentLoan.MakePayment();
            string status = $"Payment Made:\nRemaining Balance: {currentLoan.Balance:C}\n";

            currentLoan.ApplyInterest();
            status += $"New Balance After Interest: {currentLoan.Balance:C}";

            if (currentLoan.Balance <= 0)
            {
                status += "\nThe loan is now fully paid off.";
            }

            lblOutput.Text = status;
        }
    }
}


