using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entities
{
    [MetadataType(typeof(CategoryMetadata))]
    public partial class Category : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual List<Book> Books { get; set; }
    }
}
