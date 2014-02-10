using System.Data.Entity.ModelConfiguration;
using BookStore.Domain.Entities;

namespace BookStore.Data.Mapping
{
    public class AuthorMap : EntityTypeConfiguration<Author>
    {
        public AuthorMap()
        {
            ToTable("Author");
            HasKey(x => x.AuthorId);
            Property(x => x.FirstName).HasMaxLength(50);
            Property(x => x.LastName).HasMaxLength(50);

            HasMany(r => r.Books).
                WithMany(e => e.Authors).
                Map
                (
                    m =>
                    {
                        m.MapLeftKey("AuthorId");
                        m.MapRightKey("BookId");
                        m.ToTable("AuthorToBook");
                    }

                );
        }
    }
}