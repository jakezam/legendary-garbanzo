using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace legendary_garbanzo.DTOs
{
    public class PrivateMessageRead
    {
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
