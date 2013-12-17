using System;

namespace BookStore.Data
{
    public interface IUnitOfWork : IDisposable
    {
        void Commit();
    }
}
