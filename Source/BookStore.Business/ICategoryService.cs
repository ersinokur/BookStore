using System.Linq;

namespace BookStore.Business
{
    public interface ICategoryService
    {
        IQueryable GetAll();
    }
}
