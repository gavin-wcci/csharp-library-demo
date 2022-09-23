namespace csharp_library_demo.Models
{
    public class HashTag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookHashTag> Books { get; set; }
    }
}
