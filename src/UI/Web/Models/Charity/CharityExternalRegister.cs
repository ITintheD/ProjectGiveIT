using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    public class CharityExternalRegister
    {
        [Required]
        [Display(Name = "Charity Name *")]
        [StringLength(100)]
        public string ECharityName { get; set; }

        [Display(Name = "Mission")]
        [DataType(DataType.MultilineText)]
        public string EMission { get; set; }

        [Display(Name = "Location of Population Served")]
        [StringLength(100)]
        public string ELocationServed { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}-\d{7}$",
               ErrorMessage = "EIN entered is not valid. Please try again.")]
        [StringLength(10)]
        [Display(Name = "EIN (Format: xx-xxxxxxxxx) *")]
        public string EEIN { get; set; }


        [Required]
        [Display(Name = "Main Contact First Name *")]
        [StringLength(30)]
        public string EContactFirstName { get; set; }

        [Required]
        [Display(Name = "Main Contact Last Name *")]
        [StringLength(50)]
        public string EContactLastName { get; set; }

        [StringLength(50)]
        [Display(Name = "Title")]
        public string ETitle { get; set; }

        [Required]
        [Display(Name = "Telephone Number (Format: (xxx)xxx-xxxx) *")]
        [RegularExpression(@"^\(?([1-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
               ErrorMessage = "Entered phone number format is not valid.  Please try again.")]
        [StringLength(20)]
        public string EPhoneNumber { get; set; }

        [Display(Name = "Extension")]
        [StringLength(10)]
        public string EPhoneNoExtension { get; set; }

        [Required]
        [Display(Name = "Email Address (served as User Name) *")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage = "Please enter a valid email address.")]
        [StringLength(100)]
        public string EEmailAddress { get; set; }


        [Required]
        [Display(Name = "Confirm Email Address *")]
        [Compare("EEmailAddress", ErrorMessage = "The Email address and confirmation email address do not match.")]
        [StringLength(100)]
        public string EConfirmEmailAddress { get; set; }

        [Display(Name = "Street Address")]
        [StringLength(80)]
        public string EStreetAddress { get; set; }

        [Display(Name = "Street Address 2")]
        [StringLength(80)]
        public string EStreetAddress2 { get; set; }

        [StringLength(30)]
        [Display(Name = "City")]
        public string ECity { get; set; }

        [StringLength(20)]
        [Display(Name = "State")]
        public string EState { get; set; }

        [RegularExpression(@"^(\d{5}-\d{4}|\d{5}|\d{9})$|^([a-zA-Z]\d[a-zA-Z] \d[a-zA-Z]\d)$",
            ErrorMessage = "Please enter a valid zip code consists of 5 or 9 numeric characters.")]
        [StringLength(10)]
        [Display(Name = "Zip Code")]
        public string EZipCode { get; set; }

        public string ExternalLoginData { get; set; }

    }


}