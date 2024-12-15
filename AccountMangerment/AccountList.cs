using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountMangerment
{
    internal class AccountList
    {
        private ArrayList list = new ArrayList();
        public void NewAccount()
        {
            Account account = new Account();
            account.FillInfo();
            list.Add(account);
        }
        public void SaveFile()
        {
            Console.Write("Input file name to save: ");
            string fileName = Console.ReadLine();
            // read file
            try
            {
                // create stream access file
                FileStream output = new FileStream(fileName,
                    FileMode.Create, FileAccess.Write);
                // establish writer
                StreamWriter writer = new StreamWriter(output);
                // access every object in Accounts
                foreach (Account account in list)
                {
                    writer.WriteLine("{0}, {1}, {2}, {3}", account.AccountID,
                        account.FirstName, account.LastName, account.Balance);
                }
                // close connection
                writer.Close();
                output.Close();
            }
            catch (IOException e)
            {
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
        public void LoadFile()
        {
            Console.Write("Input file name to load: ");
            string fileName = Console.ReadLine();
            // clear list
            list.Clear();
            try
            {
                // create stream read file
                FileStream input = new FileStream(fileName,
                    FileMode.Open, FileAccess.Read);
                StreamReader streamReader = new StreamReader(input);
                string str;
                // read over each line, end when str = null
                while((str = streamReader.ReadLine()) != null)
                {
                    // split into sub string with ,
                    string[] listStr = str.Split(',');
                    // create new Account object
                    Account account = new Account(int.Parse(listStr[0]),
                        listStr[1], listStr[2], decimal.Parse(listStr[3]));
                    list.Add(account);
                    // close stream
                    input.Close();
                    streamReader.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public void Report()
        {
            Console.WriteLine("\nAccount List:");
            foreach (Account account in list)
            {
                account.Query();
            }
        }
        public void Remove()
        {
            Console.Write("Enter Account ID to remove: ");
            int accountId = int.Parse(Console.ReadLine());
            // sort list
            list.Sort(new CompareByAccountID());
            int index = list.BinarySearch(new Account { AccountID = accountId }, new CompareByAccountID());
            if (index >= 0)
            {
                list.RemoveAt(index);
                Console.WriteLine("Account removed successfully.");
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }
        public void SortByAccountID()
        {
            list.Sort(new CompareByAccountID());
            Console.WriteLine("Sorted by AccountID");
        }
        public void SortByFirstName()
        {
            list.Sort(new CompareByFirstName());
            Console.WriteLine("Sorted by Firstname");
        }
        public void SortByBalance()
        {
            list.Sort(new CompareByBalance());
            Console.WriteLine("Sorted by Balance.");
        }

    }
}
