using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    public class SubCategory
    {
        [Key]
        public int ProviderId { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string HourlyRate { get; set; }

        [Required]
        public string FlateRate { get; set; }
    }
}