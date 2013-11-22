using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace BookStore.Data.Utils
{
    /// <summary>
    /// Hangi data access yöntemi kullanılırsa kullanılsın bu interface'i kullanacak
    /// </summary>
    /// <typeparam name="T"></typeparam>

    public interface IRepository<T>
    {
        void Insert(T item);
        void Update(T item);
        void Delete(T item);
        T GetByIdOrPk(object[] pk);

        IList<T> GelAll();

    }
}
