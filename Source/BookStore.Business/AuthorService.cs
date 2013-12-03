using BookStore.Business.Util;
using BookStore.Data;
using BookStore.Domain.Entities;

namespace BookStore.Business
{

    public class AuthorService : ServiceBase<AuthorDataStore>
    {
        public void SaveOrUpdate(Author author)
        {         
            _dbContext.Insert(author);
        }
    }
}
