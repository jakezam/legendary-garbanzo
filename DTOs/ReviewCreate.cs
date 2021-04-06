using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class ReviewCreate
    {
        [Required]
        public Guid ReceivingUserId { get; set; }

        [Required]
        public Guid UserId { get; set; }

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
    }
}