using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Account
    {
        private string _accountNumber;
        private string _pin;
        private string _name;
        private decimal _balance;
        public Account(string accountNumber, string pin, string name, decimal balance)
        {
            _accountNumber = accountNumber;
            _pin = pin;
            _name = name;
            _balance = balance;
        }

        public string GetAccountNumber() => _accountNumber;
        public string GetPin() => _pin;
        public string GetName() => _name;
        public decimal GetBalance() => _balance;

        public void MakeDeposit(decimal amount)
        {
            _balance += amount;
        }

        public void MakeWithdrawal(decimal amount)
        {
            _balance -= amount;
        }
    }
}
