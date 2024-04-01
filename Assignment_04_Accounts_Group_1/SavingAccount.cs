using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public class SavingAccount : Account, ITransaction
    {
        private static readonly double COST_PER_TRANSACTION = 0.5;
        private static readonly double INTEREST_RATE = 0.015;
        private bool hasOverdraft = false;
        public SavingAccount(double balance = 0) : base("SV-", balance)
        {
            
        }
        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount - COST_PER_TRANSACTION, person);
        }
        public void Withdraw(double amount, Person person)
        {
            // Check whether the person is associated with this account
            if (!IsUser(person.Name))
            {
                base.OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }
            // Check whether the person is logged in
            if (person == null)
            {
                base.OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);
            }

            double totalAmount = amount + COST_PER_TRANSACTION;

            // Check whether the balance is sufficient or overdraft is enabled
            if (Balance - totalAmount < 0 && !hasOverdraft)
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.NO_OVERDRAFT);
            }
            base.Deposit(-amount, person);
        }
        public override void PrepareMonthlyReport()
        {
            double serviceCharge = Transactions.Count * COST_PER_TRANSACTION;
            double interest = LowestBalance * INTEREST_RATE / 12;
            Balance += interest - serviceCharge;
            Transactions.Clear();
            Console.WriteLine("Line 56 - Saving Account - Monthly report");
        }
    }
}
