namespace csharp_library_demo.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
    }
}
