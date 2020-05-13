namespace console_library.Interfaces
{
    public interface IBuyable
    {
        decimal Price { get; }
        void Purchase();
    }
}