using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX1
{
    internal interface ILoan
    {
        void MakePayment();
        void ApplyInterest();
        string Name { get; }
        string Type { get; }
        double Balance { get; }
    }
}
