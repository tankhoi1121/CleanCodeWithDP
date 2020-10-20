using System;
using System.Collections.Generic;
using System.Text;

namespace CleanCodeWithDP.Decorator
{
    public class Book : LibraryItem
    {
        private string _author;
        private string _title;

        public Book(string author, string title, int numCopies)
        {
            _author = author;
            _title = title;
            NumCopies = numCopies;
        }

        public override void Display()
        {
            Console.WriteLine("\nBook: ----------");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"NumCopies: {NumCopies}\n");
        }
    }
}
