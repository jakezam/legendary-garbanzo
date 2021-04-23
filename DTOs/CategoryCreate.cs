using System.ComponentModel.DataAnnotations;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.DTOs
{
    public class CategoryCreate
    {
        /*[NotMapped]
        public Guid ProviderId { get; set; }*/

        /*[NotMapped]
        public int CategoryNumber { get; set; }*/

        [Required] public string ProviderCategory { get; set; }

        [Required] public string HourlyRate { get; set; }

        [Required] public string FlatRate { get; set; }
    }
}