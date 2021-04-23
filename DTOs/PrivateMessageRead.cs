﻿using System;
using System.ComponentModel.DataAnnotations;

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
namespace legendary_garbanzo.DTOs
{
    public class PrivateMessageRead
    {
        [Required] public string Subject { get; set; }

        [Required] public string Message { get; set; }

        [Required] public Guid From { get; set; }

        [Required] public Guid To { get; set; }
    }
}