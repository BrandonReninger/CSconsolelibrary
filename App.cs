using System;
using console_library.Models;

namespace console_library
{
    public class App
    {
        public Library Library { set; get; }
        public bool Availabe { set; private get; }
        public void Run()
        {
            Library = new Library("Title", "Author");
            Console.Clear();
            Library.Setup();

            Book whereTheSidewalkEnds = new Book("Where the Sidewalk Ends", "Shel Silverstein");
            Book mossFlower = new Book("Mossflower", "Brian Jacques");
            Book theRoad = new Book("The Road", "Cormac McCarthy");
            Book theUniverseInaNutShell = new Book("The Universe in a Nutshell", "Stephen Hawking");

        }
    }
}