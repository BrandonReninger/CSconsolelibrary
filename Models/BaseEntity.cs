namespace console_library.Models
{
    public abstract class BaseEntity
    {
        public string Title { get; private set; }
        public BaseEntity(string title)
        {
            Title = title;
        }
    }
}