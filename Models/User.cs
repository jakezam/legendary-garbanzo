using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Models
{
    public class User
    {
        public User()
        {
            this.Notifications = new HashSet<Notification>();
            this.Inbox = new HashSet<PrivateMessage>();
            this.Sent = new HashSet<PrivateMessage>();
        }
        [Key]
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

        [Required] [MaxLength(64)] public string FirstName { get; set; }

        [Required] [MaxLength(64)] public string LastName { get; set; }

        [Required] public DateTime DateOfBirth { get; set; }

        [Required] [MaxLength(64)] public string Gender { get; set; }

        [Required] [MaxLength(64)] public string State { get; set; }

        [Required] public DateTime CreatedDate { get; set; }

        public ICollection<Notification> Notifications { get; set; }

        public ICollection<PrivateMessage> Inbox { get; set; }

        public ICollection<PrivateMessage> Sent { get; set; }
    }
}