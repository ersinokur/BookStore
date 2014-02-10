using System.Data.Entity.ModelConfiguration;
using BookStore.Domain.Entities;

namespace BookStore.Data.Mapping
{
    public class CategoryMap : EntityTypeConfiguration<Category>
    {
        public CategoryMap()
        {
            ToTable("Category");
            HasKey(x => x.CategoryId);

            Property(x => x.CategoryDescription).HasMaxLength(100);
            Property(x => x.CategoryName).HasMaxLength(20);
        }
    }
}