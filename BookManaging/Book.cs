using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookManaging
{
    internal class Book : IBook
    {
        #region definition data
        private string isbn;
        private string title;
        private string author;
        private string publisher;
        private int year;
        private ArrayList chapter = new ArrayList();
        #endregion
        #region Implement IBook interface
        public string this[int index]
        {
            get
            {
                if(index >= 0 && index < chapter.Count)
                {
                    return (string) chapter[index];
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
            set
            {
                if (index >= 0 && index < chapter.Count)
                {
                    chapter[index] = value; // update chapter
                }
                else if (index == chapter.Count)
                {
                    chapter.Add(value); // add new chapter
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
        public string Title
        {
            get => title;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Title cannot be null or empty");
                }
                title = value;
            }
        }
        public string Author
        {
            get => author;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Author cannot be empty or null");
                }
                author = value;
            }
        }
        public string Publisher
        {
            get => publisher;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Publisher cannot be empty or null");
                }
                publisher = value;
            }
        }
        public int Year
        {
            get => year;
            set
            {
                if(value < 0 || value > DateTime.Now.Year)
                {
                    throw new ArgumentOutOfRangeException("Year must be a valid year");
                }
                year = value;
            }
        }
        public string ISBN
        {
            get => isbn;
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("ISBN cannot be empty or null");
                }
                isbn = value;
            }
        }

        #endregion

        public void Show()
        {
            Console.WriteLine("---------------");
            Console.WriteLine("Title: "+ title);
            Console.WriteLine("Author: "+ author);
            Console.WriteLine("Publisher: "+ publisher);
            Console.WriteLine("Year: "+ year); 
            Console.WriteLine("ISBN: "+ isbn);
            Console.WriteLine("Chapter: ");
            for(int i = 0; i < chapter.Count; i++)
            {
                Console.WriteLine("\t{0}: {1}", i + 1, chapter[i]);
            }
            Console.WriteLine("---------------");
        }
        public void Input()
        {
            Console.WriteLine("Title: ");
            title = Console.ReadLine();
            Console.WriteLine("Author: ");
            author = Console.ReadLine();
            Console.WriteLine("Publisher: ");
            publisher = Console.ReadLine();
            Console.WriteLine("ISBN: ");
            isbn = Console.ReadLine();
            Console.WriteLine("Year: ");
            year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input chapter (finished with empty string");
            string str;
            do
            {
                str = Console.ReadLine();
                if (str.Length > 0)
                {
                    chapter.Add(str);
                }
            } 
            while (str.Length > 0);
        }
    }
}
