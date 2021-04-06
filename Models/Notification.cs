using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Models
{
    public class Notification
    {

        [Key]
        public Guid NotificationId { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }

        [Required]
        public Guid From { get; set; }

    }
}
