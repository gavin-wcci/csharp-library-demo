namespace csharp_library_demo.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<BookAuthor> Books { get; set; }

    }
}
