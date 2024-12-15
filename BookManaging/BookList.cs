using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    internal class BookList
    {
        // definate book list
        private ArrayList list = new ArrayList();
        // create an book object, enter fields and add to list
        public void AddBook()
        {
            Book book = new Book();
            book.Input();
            list.Add(book);
        }
        // print list
        public void ShowList()
        {
            foreach (Book book in list)
            {
                book.Show();
            }
        }
        public void InputList()
        {
            int num;
            Console.WriteLine("Amount of books: ");
            num = int.Parse(Console.ReadLine());
            while(num > 0)
            {
                AddBook();
                num--;
            }
        }
    }
}
