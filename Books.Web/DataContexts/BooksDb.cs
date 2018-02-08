﻿using Books.Entities;
using System.Data.Entity;

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
        }

        public DbSet<Book> Books { get; set; }
    }
}
