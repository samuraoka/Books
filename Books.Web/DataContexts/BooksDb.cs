using Books.Entities;
using System.Data.Entity;

namespace Books.Web.DataContexts
{
    public class BooksDb : DbContext
    {
        public BooksDb()
            : base("DefaultConnection")
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}
