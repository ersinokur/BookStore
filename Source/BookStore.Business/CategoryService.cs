using System.Linq;
using BookStore.Data.Abstracts;
using BookStore.Domain.Entities;

namespace BookStore.Business
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IQueryable<Category> GetAll()
        {
            return _categoryRepository.Get();
        }
    }
}
