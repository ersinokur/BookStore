using BookStore.Domain.Entities;
using System.Data.Entity;

namespace BookStore.Data
{
    public class BookStoreContextSeedInitializer : DropCreateDatabaseAlways<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            context.Categories.Add(new Category 
            {
                Name = "cat1",
                Description = "sample desc",
            });

            context.Categories.Add(new Category
            {
                Name = "cat2",
                Description = "sample desc",
            });

            context.SaveChanges();
        }
    }
}
