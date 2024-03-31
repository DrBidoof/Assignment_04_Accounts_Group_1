using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public static class Logger
    {
        private static List<string> loginEvents = new List<string>();
        private static List<string> transactionEvents = new List<string>();

        public static EventHandler<EventArgs> LoginHandler = (sender, args) =>
        {
            if (args is LoginEventArgs loginArgs)
            {
                string logMessage = $"{loginArgs.PersonName} - Success: {loginArgs.Success} - Time: {Utils.Now}";
                loginEvents.Add(logMessage);
            }
        };

        public static EventHandler<EventArgs> TransactionHandler = (sender, args) =>
        {
            if (args is TransactionEventArgs transactionArgs)
            {
                string operation = transactionArgs.Amount >= 0 ? "Deposit" : "Withdraw";
                string logMessage = $"{transactionArgs.PersonName} - Amount: {Math.Abs(transactionArgs.Amount)} - Operation: {operation} - Success: {transactionArgs.Success} - Time: {Utils.Now}";
                transactionEvents.Add(logMessage);
            }
        };

        public static void ShowLoginEvents()
        {
            Console.WriteLine($"Current Time: {Utils.Now}");
            Console.WriteLine("Login Events:");
            for (int i = 0; i < loginEvents.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {loginEvents[i]}");
            }
        }

        public static void ShowTransactionEvents()
        {
            Console.WriteLine($"Current Time: {Utils.Now}");
            Console.WriteLine("Transaction Events:");
            for (int i = 0; i < transactionEvents.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {transactionEvents[i]}");
            }
        }
    } 
}
