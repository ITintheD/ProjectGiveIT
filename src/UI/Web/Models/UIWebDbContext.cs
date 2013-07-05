using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    public class UIWebDbContext : DbContext
    {
        public UIWebDbContext()
            : base("name=DefaultConnection") 
        { 
        }
        public DbSet<Charity> Charities { get; set; }
        public DbSet<User> Users { get; set; }
    }
}