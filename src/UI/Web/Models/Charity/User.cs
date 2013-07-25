using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    [Table("UserProfile")]
    public class User
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }

        [StringLength(100)]
        public string UserName { get; set; }

        [StringLength(30)]
        public string ContactFirstName { get; set; }

        [StringLength(30)]
        public string ContactLastName { get; set; }

        [StringLength(30)]
        public string Title { get; set; }

        [StringLength(20)]
        public string PhoneNumber { get; set; }

        [StringLength(10)]
        public string PhoneNoExtension { get; set; }

        [StringLength(100)]
        public string EmailAddress { get; set; }
        
        public int UserType { get; set; }
    }
}