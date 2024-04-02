using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public class VisaAccount : Account, ITransaction
    {
        private double creditLimit;
        private const double INTEREST_RATE = 0.1995;

        public VisaAccount(double balance = 0, double creditLimit = 1200) : base("VS-", balance)
        {
            this.creditLimit = creditLimit;
        }

        public void DoPayment(double amount, Person person)
        {
            base.Deposit(amount, person);
            base.OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, true));
        }

        public void DoPurchase(double amount, Person person)
        {
            if (!IsUser(person.Name))
            {
                base.OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.NAME_NOT_ASSOCIATED_WITH_ACCOUNT);
            }

            if (!person.IsAuthenticated)
            {
                base.OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);
            }

            if (amount > Balance && amount > creditLimit)
            {
                base.OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.CREDIT_LIMIT_HAS_BEEN_EXCEEDED);
            }

            base.OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, true));
            base.Deposit(-amount, person);
        }
        public void Withdraw(double amount, Person person)
        {

            throw new NotSupportedException("Visa accounts do not support direct withdrawals.");
        }

        public void Deposit(double amount, Person person)
        {

            DoPayment(amount, person);
        }

        public override void PrepareMonthlyStatement()
        {
            double interest = LowestBalance * INTEREST_RATE / 12;
            Balance -= interest;
            transactions.Clear();
        }
    }
}
