using System.ComponentModel.DataAnnotations;

namespace BookStore.Domain
{
    public sealed class BookMetadata
    {
        [Required]
        [StringLength(13)]
        public string ISBN { get; set; }

        [Required]
        [StringLength(75)]
        public string Title { get; set; }
    }
}