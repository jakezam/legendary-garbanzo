using System;
#pragma warning disable 1591 /*XML Doc String Warning*/
namespace legendary_garbanzo.DTOs
{
    public class JobRead
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid ProviderId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string JobTitle { get; set; }
        public string Description { get; set; }
        public string ConsumerStatus { get; set; }
        public bool IsProviding { get; set; }
        public bool JobAccepted { get; set; }
        public bool JobModified { get; set; }
    }
}