using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    [Table("Volunteer")]
    public class Volunteer
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int VolunteerId { get; set; }

        public int Hours { get; set; }

        public string Skillset { get; set; }

        public string Resume { get; set; }

        public int UId { get; set; }

        [ForeignKey("UId")]
        public User User { get; set; }
    }
}