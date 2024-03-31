using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public struct Transaction
    {
        public string AccountNumber { get; }
        public double Amount { get; }
        public Person Originator { get; }
        public DayTime Time { get; }

        public Transaction(string accountNumber, double amount, Person person)
        {
            AccountNumber = accountNumber;
            Amount = amount;
            Originator = person;
            Time = Utils.Now; 
        }

        public override string ToString()
        {
            string transactionType = Amount >= 0 ? "Deposit" : "Withdraw";
            return $"{transactionType}: Account Number: {AccountNumber}, Person: {Originator.Name}, Amount: {Math.Abs(Amount)}, Time: {Time}";
        }
    }

}
