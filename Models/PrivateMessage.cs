using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Models
{
    public class PrivateMessage
    {

        [Key]
        public Guid PrivateMessageId { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        [Required]
        public Guid From { get; set; }
        [Required]
        public Guid To { get; set; }
    }
}