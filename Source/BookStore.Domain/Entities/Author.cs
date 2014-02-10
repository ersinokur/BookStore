using System;
using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    // [MetadataType(typeof(AuthorMetadata))]
    public class Author : BaseEntity
    {
        public int AuthorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public DateTime DeathDate { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}