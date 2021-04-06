using System;
using System.ComponentModel.DataAnnotations;
#pragma warning disable 1591 /*XML Doc String Warning*/
namespace legendary_garbanzo.DTOs
{
    public class JobCreate
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public Guid UserId { get; set; }

        [Required]
        public Guid ProviderId { get; set; }

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