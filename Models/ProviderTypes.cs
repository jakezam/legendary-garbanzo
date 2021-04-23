using System;
using System.ComponentModel.DataAnnotations;

#pragma warning disable 1591 /*XML Doc String Warning*/

namespace legendary_garbanzo.Models
{
    public class ProviderTypes
    {
        [Key] public Guid TypeId { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    }
}