﻿using System.ComponentModel.DataAnnotations;

namespace Auth_WebApplication.Models
{
    public class LoginVM
    {
        [EmailAddress]
        [Required(ErrorMessage = "Please enter email")]
        public string Email { get; set; } = default!;

        [Required(ErrorMessage = "Please enter password")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = default!;

        [Display(Name ="Remeber Me")]
        public bool RememberMe { get; set; } 
    }
}
