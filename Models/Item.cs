using console_library.Interfaces;

namespace console_library.Models
{
    public class Item : BaseEntity, IBuyable
    {
        // public string Title { get; set; }
        public decimal Price { get; private set; }
        public int Quantity { get; set; }

        public Item(string title, decimal price, int quantity) : base(title)
        {
            // Title = title;
            Price = price;
            Quantity = quantity;
        }

        public void Purchase()
        {
            System.Console.WriteLine($"You purchased {Title}, it's all yours.");
        }
    }
}