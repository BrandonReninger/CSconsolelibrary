using console_library.Interfaces;

namespace console_library.Models
{
    public class Book : BaseEntity, IBuyable
    {
        // public string Title { get; set; }
        public bool Available { get; set; }
        public decimal Price { get; private set; }
        public string Author { get; set; }

        public Book(string title, string author, decimal price) : base(title)
        {
            // Title = title;
            Author = author;
            Price = price;
            Available = true;

        }

        public void Purchase()
        {
            System.Console.WriteLine($"{Title} is all yours chief.");
        }
    }
}