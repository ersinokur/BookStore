using System.Linq;
using BookStore.Data.Abstracts;
using BookStore.Domain.Entities;

namespace BookStore.Data.Concretes
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public IQueryable<Book> GetPopularBooks()
        {
            // tempsili implementasyon, satis tablosu vs ile join lenmeli
            return Get().OrderBy(a => a.Price).Take(50);
        }
    }
}
