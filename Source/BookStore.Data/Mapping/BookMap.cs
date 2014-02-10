using System.Data.Entity.ModelConfiguration;
using BookStore.Domain.Entities;

namespace BookStore.Data.Mapping
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            ToTable("Book");
            HasKey(x => x.BookId);

            Property(x => x.ISBN).HasMaxLength(15);
            Property(x => x.Title).HasMaxLength(50);
        }
    }
}