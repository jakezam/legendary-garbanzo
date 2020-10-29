using System;

namespace legendary_garbanzo.DTOs
{
    public class ReviewRead
    {
        public int ReviewId { get; set; }
        public int ReceivingUserId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public int Rating { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public Boolean WouldRecommend { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}