﻿namespace SpinningFish.Web.Models.Account
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using static Data.DataConstants;

    public class RegisterViewModel
    {
        [Required]
        [StringLength(NameMaxLength)]
        public string Username { get; set; }

        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Firstname { get; set; }

        [Required]
        [MinLength(NameMinLength)]
        [MaxLength(NameMaxLength)]
        public string Lastname { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }

        [Required]
        public string PhoneNumber { get; set; }


    }
}
