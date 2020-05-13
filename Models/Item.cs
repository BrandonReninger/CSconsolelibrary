namespace console_library
{
    public class Item
    {
        public string Title { get; set; }
        public decimal Price { get; private set; }
        public int Quantity { get; set; }

        public Item(string title, decimal price, int quantity)
        {
            Title = title;
            Price = price;
            Quantity = quantity;
        }
    }
}