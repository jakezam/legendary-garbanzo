using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProviderId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Company { get; set; }

        [Required]
        [MaxLength(64)]
        public string Category { get; set; }

        public string Website { get; set; }

        public int Rating { get; set; }

        public string ExpertiseLevel { get; set; }

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
    }
}