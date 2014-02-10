using System.Linq;
using BookStore.Domain.Entities;

namespace BookStore.Business
{
    public interface IBookService : IGenericService<Book>
    {
        IQueryable<Book> GetAll();
    }
}