using System;
using System.Collections;
using System.Data.Entity;
using BookStore.Data.Abstracts;
using BookStore.Data.Concretes;

namespace BookStore.Data
{
    public class EFUnitOfWork : IEFUnitOfWork
    {
        private readonly DbContext _context;
        private Hashtable _repositories;
        private bool _disposed;

        public EFUnitOfWork()
        {
            _context = new BookStoreContext();
        }

        public EFUnitOfWork(DbContext context)
        {
            _context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed && disposing)
            {
                _context.Dispose();
            }
            _disposed = true;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            if (_repositories == null)  
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (_repositories.ContainsKey(type))    
                return (IRepository<TEntity>)_repositories[type];

            var repositoryType = typeof(Repository<>);
            _repositories.Add(type, Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context));

            return (IRepository<TEntity>)_repositories[type];
        }
    }
}
