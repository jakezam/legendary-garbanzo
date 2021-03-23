using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class JobUpdate
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        public int ProviderId { get; set; }

        [Required]
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }

        [Required]
        [MaxLength(255)]
        public string JobTitle { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public string ConsumerStatus { get; set; }

        [Required]
        public bool IsProviding { get; set; }

        [Required]
        public bool JobAccepted { get; set; }

        [Required]
        public bool JobModified { get; set; }
    }
}