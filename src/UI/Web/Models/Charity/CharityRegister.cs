﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    public class CharityRegister
    {
        [Required]
        [Display(Name = "Charity Name *")]
        [StringLength(100)]
        public string CharityName { get; set; }

        [Display(Name = "Mission")]
        [DataType(DataType.MultilineText)]
        public string Mission { get; set; }

        [Display(Name = "Location of Population Served")]
        [StringLength(100)]
        public string LocationServed { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}-\d{7}$",
               ErrorMessage = "EIN entered is not valid. Please try again.")]
        [StringLength(10)]
        [Display(Name = "EIN (Format: xx-xxxxxxx) *")]
        public string EIN { get; set; }


        [Required]
        [Display(Name = "Main Contact First Name *")]
        [StringLength(30)]
        public string ContactFirstName { get; set; }

        [Required]
        [Display(Name = "Main Contact Last Name *")]
        [StringLength(50)]
        public string ContactLastName { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Telephone Number (Format: (xxx)xxx-xxxx) *")]
        [RegularExpression(@"^\(?([1-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
               ErrorMessage = "Entered phone number format is not valid.  Please try again.")]
        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [Display(Name = "Extension")]
        [StringLength(10)]
        public string PhoneNoExtension { get; set; }

        [Required]
        [Display(Name = "Email Address (Served as User Name) *")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Please enter a valid email address.")]
        [StringLength(100)]
        public string EmailAddress { get; set; }


        [Required]
        [Display(Name = "Confirm Email Address *")]
        [Compare("EmailAddress", ErrorMessage = "The Email address and confirmation email address do not match.")]
        [StringLength(100)]
        public string ConfirmEmailAddress { get; set; }


        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password *")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password *")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Street Address")]
        [StringLength(80)]
        public string StreetAddress { get; set; }

        [Display(Name = "Street Address 2")]
        [StringLength(80)]
        public string StreetAddress2 { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [RegularExpression(@"^(\d{5}-\d{4}|\d{5}|\d{9})$|^([a-zA-Z]\d[a-zA-Z] \d[a-zA-Z]\d)$",
            ErrorMessage = "Please enter a valid zip code consists of 5 or 9 numeric characters.")]
        [StringLength(10)]
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }

    }
}
