using System.ComponentModel.DataAnnotations;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.DTOs
{
    public class CategoryUpdate
    {
        [Required]
        public string ProviderCategory { get; set; }

        [Required]
        public string HourlyRate { get; set; }

        [Required]
        public string FlatRate { get; set; }
    }
}