using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    [Table("Charity")]
    public class Charity
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int CharityId { get; set; }

        [StringLength(100)]
        public string CharityName { get; set; }

        public string MissionAndLocation { get; set; }

        [StringLength(10)]
        public string EIN { get; set; }

        [StringLength(80)]
        public string StreetAddress { get; set; }

        [StringLength(80)]
        public string StreetAddress2 { get; set; }

        [StringLength(30)]
        public string City { get; set; }

        [StringLength(20)]
        public string State { get; set; }

        [StringLength(10)]
        public string ZipCode { get; set; }

    }
}
