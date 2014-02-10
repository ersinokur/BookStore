using System.Collections.Generic;

namespace BookStore.Domain.Entities
{
    // [MetadataType(typeof(CategoryMetadata))]
    public partial class Category : BaseEntity//<int>
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}