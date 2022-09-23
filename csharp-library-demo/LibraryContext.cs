using Microsoft.EntityFrameworkCore;
using csharp_library_demo.Models;

namespace csharp_library_demo
{
    public class LibraryContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookHashTag> BookHashTags { get; set; }
        public DbSet<Campus> Campuses { get; set; }
        public DbSet<HashTag> HashTags { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = "Server=(localdb)\\mssqllocaldb; Database=csharp_library_demo; Trusted_Connection=True;";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            model.Entity<Campus>().HasData(new Campus { Id = 1, Location = "Cleveland" },
            new Campus { Id = 2, Location = "Columbus" });

            model.Entity<Book>().HasData(new Book { Id = 1, Title = "C# Player's Guide", CampusId = 1 }, 
                new Book { Id = 2, Title = "Head First Java", CampusId = 2 });

            model.Entity<Author>().HasData(new Author { Id = 1, FirstName = "RB", LastName = "Whitaker" },
                new Author { Id = 2, FirstName = "Kathy", LastName = "Sierra"}, 
                new Author { Id = 3, FirstName = "Burt", LastName = "Bates"});

            model.Entity<HashTag>().HasData(new HashTag { Id = 1, Name = "C#" },
                new HashTag { Id = 2, Name = "Java" },
                new HashTag { Id = 3, Name = "Programming"});

            model.Entity<BookAuthor>().HasData(new BookAuthor { Id = 1, BookId = 1, AuthorId = 1 },
                new BookAuthor { Id = 2, BookId = 2, AuthorId = 2 },
                new BookAuthor { Id = 3, BookId = 2, AuthorId = 3 });

            model.Entity<BookHashTag>().HasData(new BookHashTag { Id = 1, BookId = 1, HashtagId = 1 },
                new BookHashTag { Id = 2, BookId = 1, HashtagId = 3 },
                new BookHashTag { Id = 3, BookId = 2, HashtagId = 2 }, 
                new BookHashTag { Id = 4, BookId = 2, HashtagId = 3 });

        }
    }
}
