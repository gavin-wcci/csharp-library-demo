namespace csharp_library_demo.Models
{
    public class BookHashTag
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public int HashtagId { get; set; }
        public virtual HashTag HashTag { get; set; }

    }
}
