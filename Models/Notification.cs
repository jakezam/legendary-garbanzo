using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    public class Notification
    {
        [Key] public Guid NotificationId { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        [Required] public Guid From { get; set; }
    }
}