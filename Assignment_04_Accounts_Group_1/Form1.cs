using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_04_Accounts_Group_1
{
    public partial class Form1 : Form
    {
        private Person selectedPerson;
        private Account selectedAccount;
        //private SelectAcct<T> selectedAccountdos;
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

            
            displayAccountlbl.Text = "";
            List<Transaction> transactions = Bank.GetAllTransactions();            
            dataGridAllTransactions.DataSource = transactions;
            GetAccountsNamesIntoListBoxView(Bank.GetAccountNames());
            GetPersonsNamesIntoListBoxView(Bank.GetPersons());
            GetAccountsIntoListBoxView(Bank.GetAccounts());
        }

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
                selectedPerson = person;
                person.Login(passwordtxb.Text);
                getPersonlb.Text = person.ToString();
            }
            catch (AccountException ex)
            {
                MessageBox.Show($"{userNameTxt.Text} {ex.Message}");
                getPersonlb.Text = "";
            }

            GetPersonsNamesIntoListBoxView(Bank.GetPersons());
        }

        private void GetAccountsNamesIntoListBoxView(string[] accountsStrings)
        {
            listBoxAccounts.Items.Clear();
            listBoxAccounts.Items.Add("Account Names");
            foreach (string accountString in accountsStrings)
            {
                listBoxAccounts.Items.Add(accountString);
            }
        }

        private void GetPersonsNamesIntoListBoxView(string[] persons)
        {
            
            viewPersonsltb.Items.Clear();
            viewPersonsltb.Items.Add("Persons Status");
            foreach (string person in persons)
            {
                viewPersonsltb.Items.Add(person);
            }
        }
        private void GetAccountsIntoListBoxView(string[] persons)
        {

            viewAccountsltb.Items.Clear();
            viewAccountsltb.Items.Add("Accounts");
            foreach (string person in persons)
            {
                viewAccountsltb.Items.Add(person);
            }
        }
        private void getAccountbtn_Click(object sender, EventArgs e)
        {
            AccountType selectedAccountType = GetSelectedAccountType();

            try
            {
                switch (selectedAccountType)
                            {
                                case AccountType.Visa:
                                    selectedAccount = HandleAccount<VisaAccount>("Do Payment", "Do Purchase", visarbt.Text);
                                    break;
                                case AccountType.Checking:
                                    selectedAccount = HandleAccount<CheckingAccount>("Deposit", "Withdraw", checkingrbt.Text);
                                    break;
                                case AccountType.Savings:
                                    selectedAccount = HandleAccount<SavingAccount>("Deposit", "Withdraw", savingsrbt.Text);
                                    break;
                                default:
                                    MessageBox.Show("Invalid account type selection.");
                                    break;
                            }
                balanceResultlbl.Text = Convert.ToString(selectedAccount.Balance);
            }
            catch (AccountException ex)
            {
                MessageBox.Show($"{selectedAccountType} Account {ex.Message}");
                displayAccountlbl.Text = "";
            }
            
        }

        private T HandleAccount<T>(string addButtonLabel, string minusButtonLabel, string accountTypeLabel) where T : Account
        {
            // Get the account based on user input
            T account = Bank.GetAccount(accountTypetxtb.Text) as T;
            displayAccountlbl.Text = account.ToString();
            addBtn.Text = addButtonLabel;
            minusBtn.Text = minusButtonLabel;
            return account;
        }

        private AccountType GetSelectedAccountType()
        {
            if (visarbt.Checked)
                return AccountType.Visa;
            else if (checkingrbt.Checked)
                return AccountType.Checking;
            else if (savingsrbt.Checked)
                return AccountType.Savings;
            else
            {
                MessageBox.Show("Please select an account type.");
                return AccountType.None;               
            }
        }

        private enum AccountType
        {
            Visa,
            Checking,
            Savings,
            None
        }
        private void HandleTransaction(double amount)
        {
            // Check if selectedAccount is not null and selectedPerson is set
            if (selectedAccount != null && selectedPerson != null)
            {
                // Check the type of selectedAccount and call the appropriate method
                if (selectedAccount is VisaAccount)
                {
                    // Call DoPayment method for VisaAccount
                    if (amount < 0)
                        (selectedAccount as VisaAccount).DoPurchase(-amount, selectedPerson);
                    else
                        (selectedAccount as VisaAccount).DoPayment(amount, selectedPerson);
                }
                else if (selectedAccount is CheckingAccount)
                {
                    // Call Deposit or Withdraw method for CheckingAccount based on amount sign
                    if (amount < 0)
                        (selectedAccount as CheckingAccount).Withdraw(-amount, selectedPerson);
                    else
                        (selectedAccount as CheckingAccount).Deposit(amount, selectedPerson);
                }
                else if (selectedAccount is SavingAccount)
                {
                    // Call Deposit or Withdraw method for SavingAccount based on amount sign
                    if (amount < 0)
                        (selectedAccount as SavingAccount).Withdraw(-amount, selectedPerson);
                    else
                        (selectedAccount as SavingAccount).Deposit(amount, selectedPerson);
                }
                else
                {
                    MessageBox.Show("Invalid account type.");
                }
            }
            else
            {
                MessageBox.Show("Please select a person and an account first.");
            }
        }
        private void addBtn_Click(object sender, EventArgs e)
        {
            //a.DoPayment(1500, p0);
            //a.DoPurchase(200, p1);
            double amount;
            if (double.TryParse(addTxtb.Text, out amount))
            {
                HandleTransaction(amount);
                
            }
            else
            {
                MessageBox.Show("Invalid amount.");
            }
            balanceResultlbl.Text = Convert.ToString(selectedAccount.Balance);
        }

        private void minusBtn_Click(object sender, EventArgs e)
        {
            double amount;
            if (double.TryParse(minusTxtb.Text, out amount))
            {
                HandleTransaction(-amount); // Pass negative amount for subtraction
                
            }
            else
            {
                MessageBox.Show("Invalid amount.");
            }
            balanceResultlbl.Text = Convert.ToString(selectedAccount.Balance);
        }
    }
}
