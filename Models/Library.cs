using System;
using System.Collections.Generic;

namespace console_library.Models
{
    public class Library
    {
        private List<Book> Books { get; set; }

        public string Title { get; private set; }
        public string Author { get; private set; }

        public Library(string title, string author)
        {
            Title = title;
            Author = author;
            Books = new List<Book>();
        }

        internal void Setup()
        {
            Console.WriteLine("Welcome to The Library");

        }

        internal void PrintBooks()
        {
            for (int i = 0; i < Books.Count; i++)
            {
                Console.WriteLine($"{i + 1} {Books[i].Title} - {Books[i].Author}");
            }
        }

        internal void AddBook(Book book)
        {
            Books.Add(book);
        }

    }
}