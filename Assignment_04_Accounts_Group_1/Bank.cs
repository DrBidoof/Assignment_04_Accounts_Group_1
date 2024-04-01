using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public static class Bank
    {
        public static readonly Dictionary<string, Account> ACCOUNTS = new Dictionary<string, Account>();
        public static readonly Dictionary<string, Person> USERS = new Dictionary<string, Person>();

        static Bank()
        {
            ACCOUNTS = new Dictionary<string, Account>();
            USERS = new Dictionary<string, Person>();
        }

        public static void AddPerson(string name, string sin)
        {
            Person person = new Person(name, sin);
            person.Onlogin += Logger.LoginHandler;
            USERS[name] = person;
        }

        public static void AddAccount(Account account)
        {
            account.OnTransaction += Logger.TransactionHandler;
            ACCOUNTS[account.Number] = account;
        }

        public static void AddUserToAccount(string number, string name)
        {
            if (ACCOUNTS.TryGetValue(number, out Account account) && USERS.TryGetValue(name, out Person person))
            {
                account.AddUser(person);
            }
            else
            {
                Console.WriteLine("Account or user not found.");
            }
        }

        public static Person GetPerson(string name)
        {
            if (USERS.TryGetValue(name, out Person person))
            {
                return person;
            }
            else
            {
                throw new AccountException(ExceptionType.USER_DOES_NOT_EXIST);
            }
        }

        public static Account GetAccount(string number)
        {
            if (ACCOUNTS.TryGetValue(number, out Account account))
            {
                return account;
            }
            else
            {
                throw new AccountException(ExceptionType.ACCOUNT_DOES_NOT_EXIST);
            }
        }

        public static void PrintAccounts()
        {
            
            Console.WriteLine("Accounts:");
            foreach (var account in ACCOUNTS.Values)
            {
                Console.WriteLine(account.ToString());
            }
        }

        public static void PrintPersons()
        {
            
            Console.WriteLine("Persons:");
            foreach (var person in USERS.Values)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
