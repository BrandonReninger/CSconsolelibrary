namespace console_library.Models
{
    public class Book : BaseEntity
    {
        // public string Title { get; set; }
        public bool Available { get; set; }
        public string Author { get; set; }

        public Book(string title, string author) : base(title)
        {
            // Title = title;
            Author = author;
            Available = true;
        }
    }
}