using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookStore.Business.Util
{
   public class ServiceBase<T> where T: new()
    {
       protected T _dbContext = new T();

       public ServiceBase()
       {
           //özel işler,  AutoMapConfig.CreateMaps() v.b. gibi uygulanabilir
       }
    }
}
