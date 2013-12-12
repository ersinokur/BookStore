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

        public BookStoreContext()
        {
            Database.SetInitializer<BookStoreContext>(new BookStoreContextSeedInitializer());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // fluent api
            //modelBuilder.Entity<User>()
            //   .Property(u => u.DisplayName)
            //   .HasColumnName("display_name");
        }

    }
}
