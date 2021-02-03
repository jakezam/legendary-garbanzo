using System;
using System.ComponentModel.DataAnnotations;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Models
{
    public class Provider
    {
        [Key]
        [Required]
        public Guid ProviderId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Company { get; set; }

        [Required]
        [MaxLength(64)]
        public string Category { get; set; }

        [Required]
        public string Website { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public string ExpertiseLevel { get; set; }

        [Required]
        [MaxLength(255)]
        public string About { get; set; }

        [Required]
        [MaxLength(64)]
        public string StreetAddress { get; set; }

        [Required]
        [MaxLength(64)]
        public string AptNum { get; set; }

        [Required]
        [MaxLength(64)]
        public string City { get; set; }

        [Required]
        [MaxLength(64)]
        public string State { get; set; }

        [Required]
        [MaxLength(16)]
        public string Zip { get; set; }
        
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}