using System.Data.Entity;
using BookStore.Data.Context;
using BookStore.Domain.Entities;

namespace BookStore.Data
{
    public class BookStoreContextSeedInitializer : DropCreateDatabaseIfModelChanges<BookStoreContext>
    {
        protected override void Seed(BookStoreContext context)
        {
            context.Categories.Add(new Category
            {
                CategoryName = "cat1",
                CategoryDescription = "sample desc",
            });

            context.Categories.Add(new Category
            {
                CategoryName = "cat2",
                CategoryDescription = "sample desc",
            });

            context.SaveChanges();
        }
    }
}