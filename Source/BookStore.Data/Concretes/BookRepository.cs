using System.Linq;
using BookStore.Domain;
using BookStore.Domain.Entities;

namespace BookStore.Data
{
    public class BookRepository: Repository<Book>, IBookRepository
    {
        public IQueryable<Book> GetPopularBooks()
        {
            // tempsili implementasyon, satis tablosu vs ile join lenmeli
            return Get().OrderBy(a => a.Price).Take(50);
        }
    }
}
