using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH14_15
{
    internal class Letter
    {
        protected string _recipient;
        protected DateTime _sentDate;

        public Letter(string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }

        public string Recipient => _recipient;
        public DateTime SentDate => _sentDate;
        public virtual double Price => 0.50;

        public override string ToString()
        {
            return $"{_sentDate:ddMMMyyyy}, {_recipient}, {Price:C}";
        }
    }
}
