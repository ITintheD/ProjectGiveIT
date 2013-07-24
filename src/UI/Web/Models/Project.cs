using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    [Table("Project")]
    public class Project
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [StringLength(100)]
        public string ProjectName { get; set; }

        public string Description { get; set; }

        public int CharityId { get; set; }

        [ForeignKey("CharityId")]
        public Charity Charity { get; set; }
    }
}