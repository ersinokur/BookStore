using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain.Entities
{
    [MetadataType(typeof(BookMetadata))]
    public partial class Category : BaseEntity<int>
    {
        public string Name { get; set; }

        public string Description { get; set; }
    }
}
