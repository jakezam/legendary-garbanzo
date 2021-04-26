using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    public class PrivateMessage
    {
        [Key] public Guid PrivateMessageId { get; set; }

        [Required] public string Subject { get; set; }

        [Required] public string Message { get; set; }

        [Required] public Guid From { get; set; }

        [Required] public Guid To { get; set; }
    }
}