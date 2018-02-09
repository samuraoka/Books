using Books.Entities;
using System.Data.Entity;
using System.Diagnostics;

namespace Books.Web.DataContexts
{
    // PM> get-help entityframework
    // PM> get-help enable-migrations
    // PM> Enable-Migrations -ContextTypeName Books.Web.DataContexts.BooksDb -MigrationsDirectory DataContexts\BookMigrations
    // PM> get-help add-migration
    // PM> Add-Migration -Name InitialCreate -ConfigurationTypeName Books.Web.DataContexts.BookMigrations.Configuration
    // PM> get-help update-database
    // PM> Update-Database -ConfigurationTypeName Books.Web.DataContexts.BookMigrations.Configuration
    public class BooksDb : DbContext
    {
        public BooksDb()
            : base("DefaultConnection")
        {
            Database.Log = sql => Debug.Write(sql);
        }

        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("library");
            base.OnModelCreating(modelBuilder);
        }
    }
}
