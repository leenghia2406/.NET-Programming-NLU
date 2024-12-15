using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMangerment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccountList accountList = new AccountList();
            string command;
            do
            {
                Console.WriteLine("\nEnter a command (Add, Save, Load, Report, Exit): ");
                command = Console.ReadLine();
                switch (command.ToLower())
                {
                    case "add":
                        accountList.NewAccount();
                        break;
                    case "save":
                        accountList.SaveFile();
                        break;
                    case "load":
                        accountList.LoadFile();
                        break;
                    case "report":
                        accountList.Report();
                        break;
                    case "sortid":
                        accountList.SortByAccountID();
                        break;
                    case "sortname":
                        accountList.SortByFirstName();
                        break;
                    case "sortbalance":
                        accountList.SortByBalance();
                        break;
                    case "remove":
                        accountList.Remove();
                        break;
                    case "exit":
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid command. Please try again.");
                        break;
                }
            } while (command.ToLower() != "exit");
        }
    }
}
