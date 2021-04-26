using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class PrivateMessageRead
    {
        public Guid MessageId { get; set; }
        public string Subject { get; set; }

        public string Message { get; set; }

        public Guid From { get; set; }
        public Guid To { get; set; }
        public string ToName { get; set; }
        public string FromName { get; set; }
    }
}