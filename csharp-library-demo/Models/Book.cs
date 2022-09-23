namespace csharp_library_demo.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int CampusId { get; set; }
        public virtual Campus Campus { get; set; }
        public virtual List<BookAuthor> Authors { get; set; }
        public virtual List<BookHashTag> HashTags { get; set; }
    }
}
