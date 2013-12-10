using System.Data.Entity;
using BookStore.Domain.Entities;
using System;

namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; } 
        
        public DbSet<Book> Books { get; set; }

        public DbSet<Category> Categories { get; set; }

        public BookStoreContext() : base("Data Source=.;Initial Catalog=BookStore;Integrated Security=True")
        {
        }

        static BookStoreContext()
        {
            try
            {
                Database.SetInitializer<BookStoreContext>(new BookStoreContextSeedInitializer());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
