using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace BookStore.Data
{
    // kaynak http://www.tugberkugurlu.com/archive/generic-repository-pattern-entity-framework-asp-net-mvc-and-unit-testing-triangle
    public abstract class Repository<T> :IRepository<T> where T : class
    {
        public DbContext Context { get; set; }

        public virtual IQueryable<T> GetAll()
        {
            return Context.Set<T>();
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public virtual void Add(T entity)
        {
            Context.Set<T>().Add(entity);
        }

        public virtual void Delete(T entity)
        {
            Context.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Save()
        {
            Context.SaveChanges();
        }
    }
}
