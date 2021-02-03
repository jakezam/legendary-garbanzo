using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    public class Category
    {
        [Key]
        public int ProviderId { get; set; }

        [Required]
        public string ProviderCategory { get; set; }

        [Required]
        public string HourlyRate { get; set; }

        [Required]
        public string FlatRate { get; set; }
    }
}