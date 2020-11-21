using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class SubCategoryUpdate
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string HourlyRate { get; set; }

        [Required]
        public string FlateRate { get; set; }
    }
}