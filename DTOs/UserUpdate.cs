using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class UserUpdate
    {
        [Required]
        [MaxLength(64)]
        public string FirstName { get; set; }
        
        [Required]
        [MaxLength(64)]
        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        [MaxLength(64)]
        public string Gender { get; set; }
        
        [MaxLength(64)]
        public string State { get; set; }
    }
}