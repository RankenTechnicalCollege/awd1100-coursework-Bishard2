using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Account
    {
        private string _username;
        private string _password;
        private string _firstName;
        private bool _disabled;

        public Account(string username, string password, string firstName, bool disabled)
        {
            _username = username;
            _password = password;
            _firstName = firstName;
            _disabled = disabled;
        }

        public string Username => _username;
        public string Password => _password;
        public string FirstName => _firstName;
        public bool IsDisabled => _disabled;
    }

    public class NoUsernamePasswordException : Exception { }
    public class IncorrectPasswordException : Exception { }
    public class AccountDisabledException : Exception { }
}
