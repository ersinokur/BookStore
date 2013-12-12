using System.Linq;
using BookStore.Data.Abstracts;

namespace BookStore.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IQueryable GetAll()
        {
            return _categoryRepository.Get();
        }
    }
}
