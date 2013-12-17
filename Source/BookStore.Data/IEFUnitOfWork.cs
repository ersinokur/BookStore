using BookStore.Data.Abstracts;

namespace BookStore.Data
{
    public interface IEFUnitOfWork : IUnitOfWork
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
    }
}