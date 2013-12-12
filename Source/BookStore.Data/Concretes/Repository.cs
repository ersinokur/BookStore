using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using BookStore.Data.Abstracts;

namespace BookStore.Data.Concretes
{
    // kaynak http://www.tugberkugurlu.com/archive/generic-repository-pattern-entity-framework-asp-net-mvc-and-unit-testing-triangle
    public abstract class Repository<T> :IRepository<T> where T : class
    {
        readonly BookStoreContext _context;

        public Repository()
        {
            _context = new BookStoreContext();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate = null)
        {
            var source =  _context.Set<T>().AsQueryable();

            if (predicate != null)
            {
                source = source.Where(predicate);
            }

            return source;
        }

        public IQueryable<T> GetWith(Expression<Func<T, bool>> predicate = null, params string[] includededEntities)
        {
            var source = _context.Set<T>().AsQueryable();

            if (predicate != null)
            {
                source = source.Where(predicate);
            }

            foreach (var includededEntity in includededEntities)
            {
                source = source.Include(includededEntity);
            }

            return source;
        }

        public virtual void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            _context.SaveChanges();
        }

    
    }
}
