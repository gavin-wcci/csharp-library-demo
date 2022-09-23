namespace csharp_library_demo.Models
{
    public class Campus
    {
        public int Id { get; set; }
        public string Location { get; set; }
        public List<Book> Books { get; set; }
    }
}
