using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.Models
{
    // These are the generalized categories that providers can pick when creating an account
    public class ProviderTypes
    {
        [Key] public Guid TypeId { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    }
}