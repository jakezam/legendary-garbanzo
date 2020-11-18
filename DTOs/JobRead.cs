using System;

namespace legendary_garbanzo.DTOs
{
    public class JobRead
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProviderId { get; set; }
        public DateTime beginDate { get; set; }
        public DateTime endDate { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string ConsumerStatus { get; set; }
        public bool IsProviding { get; set; }
        public bool JobAccepted { get; set; }
        public bool JobModified { get; set; }
    }
}