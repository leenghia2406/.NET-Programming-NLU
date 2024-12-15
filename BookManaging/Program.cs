using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BookList bookList = new BookList();
            bookList.InputList();
            bookList.ShowList();
            Console.ReadLine();
        }
    }
}
