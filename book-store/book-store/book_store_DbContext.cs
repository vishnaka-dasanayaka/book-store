using System;
using book_store.Model;
using Microsoft.EntityFrameworkCore;

namespace book_store
{
	public class book_store_DbContext:DbContext
	{
        public book_store_DbContext(DbContextOptions<book_store_DbContext> options)
        : base(options)
        {
        }

        public DbSet<Book> Books { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<Admin> Admins { get; set; } = null!;
    }
}

