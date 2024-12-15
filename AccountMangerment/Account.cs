using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMangerment
{
    internal class Account
    {
        public int AccountID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Balance { get; set; }
        public Account(int accountId, string firstName, string lastName, decimal balance)
        {
            AccountID = accountId;
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }
        public Account() { }
        public void FillInfo()
        {
            Console.Write("Enter Account ID: ");
            AccountID = int.Parse(Console.ReadLine());

            Console.Write("Enter First Name: ");
            FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            LastName = Console.ReadLine();

            Console.Write("Enter Balance: ");
            Balance = decimal.Parse(Console.ReadLine());
        }
        public void Query()
        {
            Console.WriteLine("Account ID: "+ AccountID);
            Console.WriteLine("First Name: " + FirstName);
            Console.WriteLine("Last Name: "+ LastName);
            Console.WriteLine("Balance: "+ Balance);
            Console.WriteLine("---------------------------");
        }

    }
}
