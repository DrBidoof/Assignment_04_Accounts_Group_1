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
            AddPerson("Narendra", "1234-5678");    //0
            AddPerson("Ilia", "2345-6789");        //1
            AddPerson("Mehrdad", "3456-7890");     //2
            AddPerson("Vijay", "4567-8901");       //3
            AddPerson("Arben", "5678-9012");       //4
            AddPerson("Patrick", "6789-0123");     //5
            AddPerson("Yin", "7890-1234");         //6
            AddPerson("Hao", "8901-2345");         //7
            AddPerson("Jake", "9012-3456");        //8
            AddPerson("Mayy", "1224-5678");        //9
            AddPerson("Nicoletta", "2344-6789");   //10

            //initialize the ACCOUNTS collection
            AddAccount(new VisaAccount());              //VS-100000
            AddAccount(new VisaAccount(150, -500));     //VS-100001
            AddAccount(new SavingAccount(5000));        //SV-100002
            AddAccount(new SavingAccount());            //SV-100003
            AddAccount(new CheckingAccount(2000));      //CK-100004
            AddAccount(new CheckingAccount(1500, true));//CK-100005
            AddAccount(new VisaAccount(50, -550));      //VS-100006
            AddAccount(new SavingAccount(1000));        //SV-100007 


            //associate users with accounts
            string number = "VS-100000";
            AddUserToAccount(number, "Narendra");
            AddUserToAccount(number, "Ilia");
            AddUserToAccount(number, "Mehrdad");

            number = "VS-100001";
            AddUserToAccount(number, "Vijay");
            AddUserToAccount(number, "Arben");
            AddUserToAccount(number, "Patrick");

            number = "SV-100002";
            AddUserToAccount(number, "Yin");
            AddUserToAccount(number, "Hao");
            AddUserToAccount(number, "Jake");

            number = "SV-100003";
            AddUserToAccount(number, "Mayy");
            AddUserToAccount(number, "Nicoletta");

            number = "CK-100004";
            AddUserToAccount(number, "Mehrdad");
            AddUserToAccount(number, "Arben");
            AddUserToAccount(number, "Yin");

            number = "CK-100005";
            AddUserToAccount(number, "Jake");
            AddUserToAccount(number, "Nicoletta");

            number = "VS-100006";
            AddUserToAccount(number, "Ilia");
            AddUserToAccount(number, "Vijay");

            number = "SV-100007";
            AddUserToAccount(number, "Patrick");
            AddUserToAccount(number, "Hao");


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
                AccountException account_notReal = new AccountException(ExceptionType.ACCOUNT_DOES_NOT_EXIST);
                throw (account_notReal);
            }
        }

        public static void PrintAccounts()
        {

            Console.WriteLine("Accounts:");
            foreach (Account account in ACCOUNTS.Values)
            {
                Console.WriteLine(account.ToString());
            }
        }

        public static void PrintPersons()
        {

            Console.WriteLine("Persons:");
            foreach (Person person in USERS.Values)
            {
                Console.WriteLine(person.ToString());
            }
        }

        public static List<Transaction> GetAllTransactions()
        {
            List<Transaction> allTransactions = new List<Transaction>();

            foreach (Account account in ACCOUNTS.Values)
            {
                allTransactions.AddRange(account.transactions);
            }
            return allTransactions;
        }
    }
}
