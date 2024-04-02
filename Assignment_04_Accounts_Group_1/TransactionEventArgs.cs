using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public class TransactionEventArgs : LoginEventArgs
    {

        public double Amount { get; }


        public TransactionEventArgs(string personName, double amount, bool success) : base(personName, success)
        {
            Amount = amount;
        }
    }
}

