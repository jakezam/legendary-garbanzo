using System;
using System.ComponentModel.DataAnnotations;
#pragma warning disable 1591 /*XML Doc String Warning*/
namespace legendary_garbanzo.DTOs
{
    public class ReviewUpdate
    {
        [Required]
        public int Rating { get; set; }

        [Required]
        [MaxLength(255)]
        public string Header { get; set; }

        [Required]
        [MaxLength(1000)]
        public string Description { get; set; }

        [Required]
        public bool WouldRecommend { get; set; }
    }
}