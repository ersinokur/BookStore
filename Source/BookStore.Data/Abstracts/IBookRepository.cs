using System.Linq;
using BookStore.Domain;
using BookStore.Domain.Entities;

namespace BookStore.Data
{
    public interface IBookRepository : IRepository<Book>
    {
        IQueryable<Book> GetPopularBooks();


    }
}
