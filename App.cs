using System;
using console_library.Models;

namespace console_library
{
    public class App
    {
        public Library Library { set; get; }
        public bool Availabe { set; private get; }
        public bool Running { set; private get; }
        public void Run()
        {
            Library = new Library("Title", "Author");
            Console.Clear();
            Library.Setup();
            Running = true;

            while (Running)
            {
                MakeSelection();
            }
        }

        private void MakeSelection()
        {
            System.Console.WriteLine("What would you like to do? Rent / Return / Leave/ Shop");
            string choice = Console.ReadLine();
            switch (choice.ToLower())
            {
                case "rent":
                    Library.RentBook();
                    break;
                case "leave":
                    Running = false;
                    Console.WriteLine("Read again soon!");
                    Console.ReadLine();
                    break;
                case "return":
                    Library.ReturnBook();
                    break;
                case "shop":
                    Library.VisitSideDesk();
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }
    }
}