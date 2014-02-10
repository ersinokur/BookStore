using System.Linq;
using BookStore.Domain.Entities;

namespace BookStore.Business
{
    public interface ICategoryService : IGenericService<Category>
    {
        IQueryable<Category> GetAll();
    }
}