using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    public class InvalidCharacterException : Exception
    {
        public InvalidCharacterException() : base("Invalid characters in message") { }

        public InvalidCharacterException(string message) : base(message) { }
    }
}
