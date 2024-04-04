using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_04_Accounts_Group_1
{
    public static class Logger
    {
        private static readonly List<string> loginEvents = new List<string>();
        private static readonly List<string> transactionEvents = new List<string>();

        public static void LoginHandler(object sender, EventArgs args)
        {
            LoginEventArgs loginArgs = args as LoginEventArgs;
            if (loginArgs != null)
            {
                string logMessage = $"{loginArgs.PersonName} - Success: {loginArgs.Success} - Time: {Utils.Now}";
                loginEvents.Add(logMessage);
            }
        }

        public static void TransactionHandler(object sender, EventArgs args)
        {
            TransactionEventArgs transactionEventArgs = args as TransactionEventArgs;
            if (transactionEventArgs != null)
            {
                string operation = transactionEventArgs.Amount >= 0 ? "Deposit" : "Withdraw";
                string logMessage = $"{transactionEventArgs.PersonName} - Amount: {Math.Abs(transactionEventArgs.Amount)} - Operation: {operation} - Success: {transactionEventArgs.Success} - Time: {Utils.Now}";
                transactionEvents.Add(logMessage);
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

        public static string GetLoginEvents() // currently working on 
        {
            string logingEvents = $"Current Time: {Utils.Now}";
            logingEvents += "\nTransaction Events:";
            for (int i = 0; i < loginEvents.Count; i++)
            {                
                logingEvents += $"\n{i + 1}. {loginEvents[i]}";
            }
            return logingEvents;
        }

        public static string GetTransactionEvents()
        {
            string logingEvents = $"Current Time: {Utils.Now}";
            logingEvents += "\nTransaction Events:";
            for (int i = 0; i < transactionEvents.Count; i++)
            {
                logingEvents += $"\n{i + 1}. {transactionEvents[i]}";
            }
            return logingEvents;
        }
    }
}
