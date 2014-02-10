using System.Linq;
using BookStore.Data.Abstracts;
using BookStore.Data.UnitOfWork;
using BookStore.Domain.Entities;

namespace BookStore.Business
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _uow;
        private readonly IGenericRepository<Author> _authorRepository;
        private readonly IGenericRepository<Book> _bookRepository;

        public AuthorService(IUnitOfWork uow)
        {
            _uow = uow;
            _authorRepository = uow.GetRepository<Author>();
            _bookRepository = uow.GetRepository<Book>();
        }

        public IQueryable<Author> GetAll()
        {
            return _authorRepository.Get();
        }

        public Author Find(int id)
        {
            return _authorRepository.Find(id);
        }

        public void Insert(Author entityInsert)
        {
            _authorRepository.Add(entityInsert);
        }

        public void Update(Author entityUpdate)
        {
            _authorRepository.Edit(entityUpdate);
        }

        public void Delete(Author entityDelete)
        {
            _authorRepository.Delete(entityDelete);
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }

#warning satis tablosu ile aktif hale gelecek

        public IQueryable<Author> GetMostPopularAuthors()
        {
            return null;
            //return _authorRepository.Get(
        }
    }
}