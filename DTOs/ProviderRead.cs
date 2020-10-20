using System;

namespace legendary_garbanzo.DTOs
{
    public class ProviderRead
    {
        public int ProviderId { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public string Website { get; set; }
        public int Rating { get; set; }
    }
}