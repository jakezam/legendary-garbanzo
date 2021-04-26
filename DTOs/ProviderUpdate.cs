using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class ProviderUpdate
    {
        [Required] [MaxLength(255)] public string Company { get; set; }

        [Required] [MaxLength(64)] public string Category { get; set; }

        [Required] public string Website { get; set; }

        [Required] public int Rating { get; set; }

        [Required] public string ExpertiseLevel { get; set; }

        [Required] [MaxLength(255)] public string About { get; set; }

        [Required] [MaxLength(64)] public string StreetAddress { get; set; }

        [Required] [MaxLength(64)] public string AptNum { get; set; }

        [Required] [MaxLength(64)] public string City { get; set; }

        [Required] [MaxLength(64)] public string State { get; set; }

        [Required] [MaxLength(16)] public string Zip { get; set; }
    }
}