using System.Data.Entity;
using BookStore.Domain.Entities;

namespace BookStore.Data
{
    public class BookStoreContext : DbContext
    {
        public DbSet<Author> Authors { get; set; } 
        
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
