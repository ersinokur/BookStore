using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    //[MetadataType(typeof(BookMetadata))]
    public partial class Book : BaseEntity
    {
        public int BookId { get; set; }

        public string ISBN { get; set; }

        public string Title { get; set; }

        public string Decription { get; set; }

        public int YearPublished { get; set; }

        public int Edition { get; set; }

        public int Volume { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }

        public virtual List<Author> Authors { get; set; }
    }
}