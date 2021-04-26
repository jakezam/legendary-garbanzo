﻿using System;
using System.ComponentModel.DataAnnotations;

namespace legendary_garbanzo.DTOs
{
    public class CategoryRead
    {
        [Key] [Required] public Guid ProviderId { get; set; }

        [Key] [Required] public int CategoryNumber { get; set; }

        [Required] public string ProviderCategory { get; set; }

        [Required] public string HourlyRate { get; set; }

        [Required] public string FlatRate { get; set; }
    }
}