﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{

    public class SavingAccount : Account, ITransaction
    {
        private const double COST_PER_TRANSACTION = 0.5;
        private const double INTEREST_RATE = 0.015;
        private readonly bool hasOverdraft;
        public SavingAccount(double balance = 0, bool hasOverdraft = false) : base("SV-", balance)
        {
            this.hasOverdraft = hasOverdraft;
        }

        public new void Deposit(double amount, Person person)
        {
            base.Deposit(amount, person);
            OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, true));
        }

        public void Withdraw(double amount, Person person)
        {
            if (!IsUser(person.Name))
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.USER_DOES_NOT_EXIST);
            }

            if (!person.IsAuthenticated)
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.USER_NOT_LOGGED_IN);
            }

            if (amount > base.Balance && !hasOverdraft)
            {
                OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, false));
                throw new AccountException(ExceptionType.NO_OVERDRAFT);
            }

            base.Deposit(-amount, person);
            OnTransactionOccur(this, new TransactionEventArgs(person.Name, amount, true));
        }

        public override void PrepareMonthlyStatement()
        {
            double serviceCharge = COST_PER_TRANSACTION * transactions.Count;
            double interest = LowestBalance * INTEREST_RATE / 12;
            Balance += interest - serviceCharge;
            transactions.Clear();
        }
    }
}
