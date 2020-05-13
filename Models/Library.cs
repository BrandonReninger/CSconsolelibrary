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

        public SideDesk Sidedesk { get; private set; }

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
            Console.WriteLine("Which Book?");
            string choice = Console.ReadLine();

            int index;
            if (int.TryParse(choice, out index) != false && index - 1 < Books.Count && index - 1 > -1)
            {
                Book book = Books[index - 1];

                if (!book.Available)
                {
                    Console.WriteLine("That book is checked out chief.");
                }
                else
                {
                    book.Available = false;
                    Console.WriteLine($"You checked out {book.Title} by {book.Author}");
                }
            }
            else
            {
                Console.WriteLine("That's an invalid choice brodawg!");
            }
        }

        internal void VisitSideDesk()
        {

        }

        internal void ReturnBook()
        {
            PrintBooks(false);
            Console.WriteLine("Which book?");
            string choice = Console.ReadLine();
            int index;
            if (int.TryParse(choice, out index) != false && index - 1 < Books.Count && index - 1 > -1)
            {
                Book book = Books[index - 1];

                if (book.Available)
                {
                    Console.WriteLine("That's been returned already, c'mon man!");
                }
                else
                {
                    book.Available = true;
                    Console.WriteLine($"You returned {book.Title} by {book.Author}.");
                }
            }
            else
            {
                Console.WriteLine("You can't do that sir. Try a different index");
            }
        }

        internal void PrintBooks(bool available)
        {
            Console.WriteLine("Books that are checked out: ");
            for (int i = 0; i < Books.Count; i++)
            {
                Book book = Books[i];
                if (book.Available = available)
                {
                    Console.WriteLine($"{i + 1} - {book.Title}");
                }
            }
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