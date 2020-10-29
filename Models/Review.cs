using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        public int ReceivingUserId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Username { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        [MaxLength(255)]
        public string Header { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public Boolean WouldRecommend { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }
    }
}