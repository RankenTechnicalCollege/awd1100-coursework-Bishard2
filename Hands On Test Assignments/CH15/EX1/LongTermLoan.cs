using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal class LongTermLoan : ILoan
    {
        private string name;
        private double balance;
        private const double interestRate = 0.05;
        private const double monthlyPayment = 200.0;

        public LongTermLoan(string name, double amount)
        {
            this.name = name;
            this.balance = amount;
        }

        public string Name => name;
        public string Type => "Long-Term Loan";
        public double Balance => balance;

        public void MakePayment()
        {
            balance -= monthlyPayment;
        }

        public void ApplyInterest()
        {
            balance += balance * interestRate;
        }
    }
}
