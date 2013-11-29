using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BookStore.Domain.EntitiesMetadata;

namespace BookStore.Domain.Entities
{
   [MetadataType(typeof(AtuhorMetadata))]
   public class Author : BaseEntity
    {
        public string FirstName  { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DeathDate { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
