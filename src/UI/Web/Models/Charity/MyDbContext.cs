using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GiveIT.UI.Web.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("name=DefaultConnection")
        {
        }
        public DbSet<Charity> Charities { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Volunteer> Volunteers { get; set; }
       
    }
}