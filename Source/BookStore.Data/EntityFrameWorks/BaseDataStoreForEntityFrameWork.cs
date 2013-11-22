using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookStore.Data.Utils;
using System.Data.Entity;

namespace BookStore.Data.EntityFrameWorks
{
    public class BaseDataStoreForEntityFrameWork<T> : IRepository<T> where T :class
    {

        private readonly BookStoreContext _context;
        private readonly DbSet<T> _dbSet;


        public BaseDataStoreForEntityFrameWork()
        {
            _dbSet = _context.Set<T>();
        }

        //public BaseDataStoreForEntityFrameWork(BookStoreContext context)
        //{
        //    _context = context;
        //    _dbSet = context.Set<T>();
        //}
        


        public void Insert(T item)
        {
            _dbSet.Add(item);
        }

        public void Update(T item)
        {
            throw new NotImplementedException();
        }

        public void Delete(T item)
        {
            throw new NotImplementedException();
        }

        public T GetByIdOrPk(object[] pk)
        {
            throw new NotImplementedException();
        }

        public IList<T> GelAll()
        {
            throw new NotImplementedException();
        }
    }
}
