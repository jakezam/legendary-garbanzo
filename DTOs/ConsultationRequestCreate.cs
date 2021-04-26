using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class ConsultationRequestCreate
    {
        [Required] public Guid To { get; set; }

        [Required] public Guid From { get; set; }

        [Required]
        public string Time { get; set; }

        [Required]
        public string Day { get; set; }
        
        [Required]
        public string ProviderCategory { get; set; }

        [Required]
        public string Message { get; set; }
    }
}