﻿using System.ComponentModel.DataAnnotations;

namespace BloodBankMSApi.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Password { get; set; }
    }
}
