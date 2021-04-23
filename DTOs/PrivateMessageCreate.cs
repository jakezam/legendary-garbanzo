﻿using System;
using System.ComponentModel.DataAnnotations;

#pragma warning disable 1591 /*XML Doc String Warning*/
namespace legendary_garbanzo.DTOs
{
    public class PrivateMessageCreate
    {
        [Required] public string Subject { get; set; }

        [Required] public string Message { get; set; }

        [Required] public Guid From { get; set; }

        [Required] public Guid To { get; set; }
    }
}