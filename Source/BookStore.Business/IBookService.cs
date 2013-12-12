using System.Linq;
using BookStore.Domain.Entities;

namespace BookStore.Business
{
    public interface IBookService
    {
        IQueryable<Book> GetAll();
    }
}
