using System.Linq;
using BookStore.Domain.Entities;

namespace BookStore.Data.Abstracts
{
    public interface IBookRepository : IRepository<Book>
    {
        IQueryable<Book> GetPopularBooks();


    }
}
