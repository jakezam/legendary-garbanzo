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

        public string Subject { get; set; }

        public string Message { get; set; }

        public Guid From { get; set; }

        public Guid To { get; set; }
    }
}