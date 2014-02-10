using System;
using BookStore.Data.Abstracts;

namespace BookStore.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<T> GetRepository<T>() where T : class;

        int Commit();
    }
}