namespace console_library.Models
{
    public class Item : BaseEntity
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
    }
}