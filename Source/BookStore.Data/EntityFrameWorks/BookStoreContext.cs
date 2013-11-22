using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BookStore.Domain.Entities;

namespace BookStore.Data.EntityFrameWorks
{
#warning gereksiz yere kullanilmayan orm kutuphanlerini engellemek icin secilen orm ayri bir proje ile ref.alınabilir mi?
        
    public class BookStoreContext:DbContext
    {
        public DbSet<Author> Authors { get; set; }
    }
}
