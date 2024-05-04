using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace BookShop.Models
{
    public class ApplicationModel
    {
        [Key]
        public int ApplicationId { get; set; }

        [Required]
        public int JobListingId { get; set; }

        [Required]
        public string? Message { get; set; }

        // Navigation property if needed
        public string? Description { get; set; }

        [DisplayName("Order of Display")]
        [Range(1, int.MaxValue, ErrorMessage = "Display order must be a positive number.")]
        public int DisplayOrder { get; set; }
    }
}
