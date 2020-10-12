using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        [MaxLength(64)]
        public string Gender { get; set; }
        
        [Required]
        [MaxLength(64)]
        public string State { get; set; }
        
        [Required]
        public DateTime CreatedDate { get; set; }
    }
}