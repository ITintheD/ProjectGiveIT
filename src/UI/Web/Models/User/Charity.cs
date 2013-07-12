using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    [Table("Charity")]
    public class Charity : User
    {
        [Required]
        [Display(Name = "Charity Name *")]
        [StringLength(100)]
        public string CharityName { get; set; }
        
        [Display(Name = "Mission, Location of Population Served")]
        [DataType(DataType.MultilineText)]
        public string MissionAndLocation { get; set; }

        [Required]
        [RegularExpression(@"^\d{2}-\d{7}$",
               ErrorMessage = "EIN entered is not valid. Please try again.")]
        [StringLength(10)]
        public string EIN { get; set; }
    }
}
