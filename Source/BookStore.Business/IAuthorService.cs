using System.Linq;
using BookStore.Domain.Entities;

namespace BookStore.Business
{
    public interface IAuthorService : IGenericService<Author>
    {
        // temsili, en çok satan 50 kitabın yazarı
        IQueryable<Author> GetMostPopularAuthors();
    }
}