using System;
#pragma warning disable 1591 /*XML Doc String Warning*/
namespace legendary_garbanzo.DTOs
{
    public class ReviewRead
    {
        public Guid ReviewId { get; set; }
        public Guid ReceivingUserId { get; set; }
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public int Rating { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public bool WouldRecommend { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}