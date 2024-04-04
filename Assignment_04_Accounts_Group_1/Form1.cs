using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_04_Accounts_Group_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();                     
            Person p0, p1, p2, p3, p4, p5, p6, p7, p8, p9, p10;
            p0 = Bank.GetPerson("Narendra");
            p1 = Bank.GetPerson("Ilia");
            p2 = Bank.GetPerson("Mehrdad");
            p3 = Bank.GetPerson("Vijay");
            p4 = Bank.GetPerson("Arben");
            p5 = Bank.GetPerson("Patrick");
            p6 = Bank.GetPerson("Yin");
            p7 = Bank.GetPerson("Hao");
            p8 = Bank.GetPerson("Jake");
            p9 = Bank.GetPerson("Mayy");
            p10 = Bank.GetPerson("Nicoletta");

            
            p0.Login("123"); p1.Login("234");
            p2.Login("345"); p3.Login("456");
            p4.Login("567"); p5.Login("678");
            p6.Login("789"); p7.Login("890");
            p10.Login("234"); p8.Login("901");
            

            VisaAccount a = Bank.GetAccount("VS-100000") as VisaAccount;
            a.DoPayment(1500, p0);
            a.DoPurchase(200, p1);
            a.DoPurchase(25, p2);
            a.DoPurchase(15, p0);
            a.DoPurchase(39, p1);
            a.DoPayment(400, p0);
            Console.WriteLine(a);
            Console.WriteLine();

            SavingAccount b = Bank.GetAccount("SV-100002") as SavingAccount;
            b.Withdraw(300, p6);
            b.Withdraw(32.90, p6);
            b.Withdraw(50, p7);
            b.Withdraw(111.11, p8);
            Console.WriteLine(b);
            Console.WriteLine();

            b = Bank.GetAccount("SV-100003") as SavingAccount;
            b.Deposit(300, p3);     //ok even though p3 is not a holder
            b.Deposit(32.90, p2);
            b.Deposit(50, p5);
            b.Withdraw(111.11, p10);
            Console.WriteLine(b);
            Console.WriteLine();


            CheckingAccount c = Bank.GetAccount("CK-100004") as CheckingAccount;
            c.Deposit(33.33, p7);
            c.Deposit(40.44, p7);
            c.Withdraw(150, p2);
            c.Withdraw(200, p4);
            c.Withdraw(645, p6);
            c.Withdraw(350, p6);
            Console.WriteLine(c);
            Console.WriteLine();

            c = Bank.GetAccount("CK-100005") as CheckingAccount;
            c.Deposit(33.33, p8);
            c.Deposit(40.44, p7);
            c.Withdraw(450, p10);
            c.Withdraw(500, p8);
            c.Withdraw(645, p10);
            c.Withdraw(850, p10);
            Console.WriteLine(c);
            Console.WriteLine();

            a = Bank.GetAccount("VS-100006") as VisaAccount;
            a.DoPayment(700, p0);
            a.DoPurchase(20, p3);
            a.DoPurchase(10, p1);
            a.DoPurchase(15, p1);
            Console.WriteLine(a);
            Console.WriteLine();

            b = Bank.GetAccount("SV-100007") as SavingAccount;
            b.Deposit(300, p3);     //ok even though p3 is not a holder
            b.Deposit(32.90, p2);
            b.Deposit(50, p5);
            b.Withdraw(111.11, p7);
            Console.WriteLine(b);
            Console.WriteLine();

            Console.WriteLine("\n\nExceptions:");
            //The following will cause exception
            
            try
            {
                p3.Logout();
                a.DoPurchase(12.5, p3);     //exception user is not logged in
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }

            try
            {
                a.DoPurchase(12.5, p0);     //user is not associated with this account
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }

            try
            {
                a.DoPurchase(5825, p4);     //credit limit exceeded
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }
            try
            {
                c.Withdraw(1500, p6);       //no overdraft
            }
            catch (AccountException e) { Console.WriteLine(e.Message); }

            

            //foreach (var keyValuePair in Bank.ACCOUNTS)
            //{
            //    Account account = keyValuePair.Value;
            //    Console.WriteLine("\nBefore PrepareMonthlyReport()");
            //    Console.WriteLine(account);

            //    Console.WriteLine("\nAfter PrepareMonthlyReport()");
            //    account.PrepareMonthlyStatement();   //all transactions are cleared, balance changes
            //    Console.WriteLine(account);
            //}


            dataGridViewAccounts.DataSource = CreateDataTable(Bank.GetAccounts(), "All Accounts");
            dataGridViewPersons.DataSource = CreateDataTable(Bank.GetPersons(), "All Persons");
            List<Transaction> transactions = Bank.GetAllTransactions();            
            dataGridAllTransactions.DataSource = transactions;
            
        }

        private DataTable CreateDataTable(string[] bankAllAccounts, string columTittle)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add(columTittle);
            foreach (string bankAccount in bankAllAccounts)
            {
                dataTable.Rows.Add(bankAccount);
            }
            return dataTable;
        }

        //private DataTable CreateTransactionDataTable(List<Transaction> allTransactions)
        //{
        //    DataTable dataTable = new DataTable();
        //    DataColumn colAccount = new DataColumn("Account", typeof(string));
        //    DataColumn colAmount = new DataColumn("Amount", typeof(string));
        //    DataColumn colType = new DataColumn("Type", typeof(string));
        //    DataColumn colOriginator = new DataColumn("Originator", typeof(string));
        //    DataColumn colDateTime = new DataColumn("Date and Time", typeof(DateTime));

        //    dataTable.Columns.Add(colAccount);
        //    dataTable.Columns.Add(colAmount);
        //    dataTable.Columns.Add(colType);
        //    dataTable.Columns.Add(colOriginator);
        //    dataTable.Columns.Add(colDateTime);

        //    //dataTable.Columns.Add(columTittle);
        //    foreach (Transaction transaction  in allTransactions)
        //    {
        //        DataRow row = dataTable.NewRow();
        //        row[colAccount] = transaction.AccountNumber.ToString();
        //    }
        //    return dataTable;
        //}

        private void loginEventsbtn_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void transactionEventslbl_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            try
            {
                Person person = Bank.GetPerson(userNameTxt.Text);
                person.Login(passwordtxb.Text);
                getPersonlb.Text = person.ToString();
            }
            catch (AccountException ex)
            {
                MessageBox.Show($"{userNameTxt.Text} {ex.Message}");
                getPersonlb.Text = "";
            }            
        }
    }
}
