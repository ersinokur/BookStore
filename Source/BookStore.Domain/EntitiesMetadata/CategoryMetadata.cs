using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain
{
    public sealed class CategoryMetadata
    {
        [Required]
        public string Name { get; set; }
    }
}