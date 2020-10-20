using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class ProviderUpdate
    {
        [Required]
        [MaxLength(255)]
        public string Company { get; set; }

        [Required]
        [MaxLength(64)]
        public string Category { get; set; }

        public string Website { get; set; }

        public int Rating { get; set; }
    }
}