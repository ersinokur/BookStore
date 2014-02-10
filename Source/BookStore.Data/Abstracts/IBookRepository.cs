using System.Linq;
using BookStore.Domain.Entities;

namespace BookStore.Data.Abstracts
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        IQueryable<Book> GetPopularBooks();
    }
}