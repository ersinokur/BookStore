using System.Linq;
using BookStore.Domain;
using BookStore.Domain.Entities;

namespace BookStore.Data
{
    interface IBookRepository
    {
        IQueryable<Book> GetPopularBooks();


    }
}
