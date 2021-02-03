namespace legendary_garbanzo.DTOs
{
    public class CategoryRead
    {
        public int UserId { get; set; }
        public string Category { get; set; }
        public string HourlyRate { get; set; }
        public string FlatRate { get; set; }
    }
}