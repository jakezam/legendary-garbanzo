﻿using System;
using System.ComponentModel.DataAnnotations;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.DTOs
{
    public class UserRead
    {
        [Key]
        [Required]
        public Guid UserId { get; set; }
        
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