using System;

namespace legendary_garbanzo.DTOs
{
    public class UserRead
    {
        public int UserId { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        public string Gender { get; set; }
        
        public string State { get; set; }
        
        public DateTime CreatedDate { get; set; }
    }
}