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

        public void Setup()
        {
            Console.WriteLine("Welcome to The Library");
            //Library.PrintBooks();
            Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
            Book mossFlower = new Book("Mossflower", "Brian Jacques");
            Book theRoad = new Book("The Road", "Cormac McCarthy");
            Book theUniverseInaNutShell = new Book("The Universe in a Nutshell", "Stephen Hawking");
            Books.Add(whereTheSidewalkEnds);
            Books.Add(mossFlower);
            Books.Add(theRoad);
            Books.Add(theUniverseInaNutShell);
        }

        internal void RentBook()
        {
            PrintBooks();

        }

        internal void PrintBooks()
        {
            Console.WriteLine("Available Books: ");
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