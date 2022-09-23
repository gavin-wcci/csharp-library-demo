using csharp_library_demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace csharp_library_demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private LibraryContext _db;

        public BookController(LibraryContext db)
        {
            _db = db;
        }
        
        //Get All Books
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Book>>> GetBooks()
        {
            if(_db.Books == null)
            {
                return NotFound();
            }
            return await _db.Books.ToListAsync();
        }

        //Get a specific book by id
        [HttpGet("{id}")]
        public ActionResult<Book> GetBook(int id)
        {
            Book book = _db.Books.Find(id);
            if(book == null)
            {
                return NotFound();
            }
            return book;
        }

        //Create a new book
        [HttpPost]
        public ActionResult<IEnumerable<Book>> Post(Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();

            return _db.Books;
        }

        //Update a book
        [HttpPut("{id}")]
        public ActionResult<IEnumerable<Book>> Put(int id, Book book)
        {
            if(book.Id == id)
            {
                _db.Books.Update(book);
                _db.SaveChanges();
            }

            return _db.Books;
        }

        [HttpDelete("{id}")]
        public ActionResult<IEnumerable<Book>> Delete(int id)
        {
            Book book = _db.Books.Find(id);
            _db.Books.Remove(book);
            _db.SaveChanges();
            return _db.Books;
        }

    }
}
