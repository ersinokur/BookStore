using System.Linq;

namespace BookStore.Business
{
    public interface IGenericService<T>
    {
        IQueryable<T> GetAll();

        T Find(int id);

        void Insert(T entityInsert);

        void Update(T entityUpdate);

        void Delete(T entityDelete);

        void Delete(int id);
    }
}