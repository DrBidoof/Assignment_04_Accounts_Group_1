﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public interface ITransaction
    {
        void Withdraw(double amount, Person person);
        void Deposit(double amount, Person person);

    }
}
