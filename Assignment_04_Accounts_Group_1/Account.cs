using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public abstract class Account
    {
        private static int LAST_NUMBER = 100000;

        private readonly List<Person> users = new List<Person>();
        protected readonly List<Transaction> transactions = new List<Transaction>();

        public event EventHandler<EventArgs> OnTransaction;

        public string Number { get; }
        public double Balance { get; protected set; }
        public double LowestBalance { get; protected set; }

        public Account(string type, double balance)
        {
            Number = $"{type}-{++LAST_NUMBER}";
            Balance = balance;
            LowestBalance = balance;
        }

        public void Deposit(double amount, Person person)
        {
            Balance += amount;
            LowestBalance = Math.Min(Balance, LowestBalance);
            Transaction transaction = new Transaction(Number, amount, person);
            transactions.Add(transaction);
            OnTransactionOccur(this, EventArgs.Empty);
        }

        public void AddUser(Person person)
        {
            users.Add(person);
        }

        public bool IsUser(string name)
        {
            return users.Any(user => user.Name == name);
        }

        public abstract void PrepareMonthlyStatement();

        public virtual void OnTransactionOccur(object sender, EventArgs args)
        {
            OnTransaction?.Invoke(sender, args);
        }

        public override string ToString()
        {
            string userInfo = string.Join(", ", users.Select(user => user.Name));
            string transactionInfo = string.Join(", ", transactions);
            return $"Account Number: {Number}, Users: {userInfo}, Balance: {Balance}, Transactions: {transactionInfo}";
        }
    }
}
