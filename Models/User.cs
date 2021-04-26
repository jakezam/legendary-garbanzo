using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    public class User
    {
        // Within the database this entries will be linked by key
        public User()
        {
            Notifications = new HashSet<Notification>();
            Inbox = new HashSet<PrivateMessage>();
            Sent = new HashSet<PrivateMessage>();
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

        public ICollection<Notification> Notifications { get; set; }

        public ICollection<PrivateMessage> Inbox { get; set; }

        public ICollection<PrivateMessage> Sent { get; set; }
    }
}