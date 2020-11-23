using System;

namespace legendary_garbanzo.DTOs
{
    public class ProviderRead
    {
        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string Company { get; set; }
        public string Category { get; set; }
        public string Website { get; set; }
        public int Rating { get; set; }

        public string ExpertiseLevel { get; set; }

        public string About { get; set; }

        public string StreetAddress { get; set; }

        public string AptNum { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zip { get; set; }
    }
}