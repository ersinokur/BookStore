using System;
using System.Linq;
using System.Linq.Expressions;

namespace BookStore.Data.Abstracts
{
    // kaynak http://www.tugberkugurlu.com/archive/generic-repository-pattern-entity-framework-asp-net-mvc-and-unit-testing-triangle
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Get(Expression<Func<T, bool>> predicate=null);

        IQueryable<T> GetWith(Expression<Func<T, bool>> predicate=null, params string[] includededEntities);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);

        void Save();
    }
}
