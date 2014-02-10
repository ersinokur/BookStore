using System.Linq;
using BookStore.Data.Abstracts;
using BookStore.Data.UnitOfWork;
using BookStore.Domain.Entities;

namespace BookStore.Business
{
    public class CategoryService : ICategoryService
    {
        //private readonly ICategoryRepository _categoryRepository;

        //public CategoryService(ICategoryRepository categoryRepository)
        //{
        //    _categoryRepository = categoryRepository;
        //}

        //public IQueryable<Category> GetAll()
        //{
        //    return _categoryRepository.Get();
        //}

        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Book> _bookRepository;
        private readonly IGenericRepository<Category> _categoryRepository;

        public CategoryService(IUnitOfWork uow)
        {
            _uow = uow;
            _categoryRepository = uow.GetRepository<Category>();
            _bookRepository = uow.GetRepository<Book>();
        }

        public IQueryable<Category> GetAll()
        {
            return _categoryRepository.Get();
        }

        public Category Find(int id)
        {
            return _categoryRepository.Find(id);
        }

        public void Insert(Category entityInsert)
        {
            _categoryRepository.Add(entityInsert);
        }

        public void Update(Category entityUpdate)
        {
            _categoryRepository.Edit(entityUpdate);
        }

        public void Delete(Category entityDelete)
        {
            _categoryRepository.Delete(entityDelete);
        }

        public void Delete(int id)
        {
            _categoryRepository.Delete(id);
        }
    }
}