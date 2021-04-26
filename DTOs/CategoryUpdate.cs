using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class CategoryUpdate
    {
        [Required] public string ProviderCategory { get; set; }

        [Required] public string HourlyRate { get; set; }

        [Required] public string FlatRate { get; set; }
    }
}