using System;
using System.Collections.Generic;
using console_library.Interfaces;

namespace console_library.Models
{
    public class Library : BaseEntity
    {
        private List<Book> Books { get; set; }
        public List<IBuyable> Cart { get; set; }
        public SideDesk SideDesk { get; private set; }

        // public string Title { get; private set; }
        public string Author { get; private set; }

        public Library(string title, string author) : base(title)
        {
            // Title = title;
            Author = author;
            Books = new List<Book>();


            SideDesk = new SideDesk();
        }

        public void Setup()
        {
            Console.WriteLine("Welcome to The Library");
            //Library.PrintBooks();
            Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein", 19.99m);
            Book mossFlower = new Book("Mossflower", "Brian Jacques", 9.99m);
            Book theRoad = new Book("The Road", "Cormac McCarthy", 14.99m);
            Book theUniverseInaNutShell = new Book("The Universe in a Nutshell", "Stephen Hawking", 4.99m);
            Books.Add(whereTheSidewalkEnds);
            Books.Add(mossFlower);
            Books.Add(theRoad);
            Books.Add(theUniverseInaNutShell);

            Cart = new List<IBuyable>();
            Item plasmasword = new Item("Plasma Sword", 450.00m, 20);
            Book theodyssey = new Book("The Odyssey", "Homer", 0.99m);
            Cart.Add(plasmasword);
            Cart.Add(theodyssey);

            foreach (IBuyable cartItem in Cart)
            {
                cartItem.Purchase();
            }
        }

        public void VisitSideDesk()
        {
            SideDesk.VisitSideDesk();
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