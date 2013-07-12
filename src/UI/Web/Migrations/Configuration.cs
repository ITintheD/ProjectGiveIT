namespace GiveIT.UI.Web.Migrations
{
    using GiveIT.UI.Web.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GiveIT.UI.Web.Models.UIWebDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(GiveIT.UI.Web.Models.UIWebDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

        //    context.Users.AddOrUpdate(r => r.ContactFirstName,
        //        new User 
        //        { 
        //            ContactFirstName = "Joe",
        //            ContactLastName = "Doe",
        //            Title = "CEO",
        //            PhoneNumber = "(111)111-1111",
        //            PhoneNoExtension = "",
        //            EmailAddress = "test@test.com"
        //        });

        //    context.Charities.AddOrUpdate(r => r.CharityName,
        //        new Charity 
        //        { 
        //            CharityName = "testC",
        //            MissionAndLocation = "blahblahblah",
        //            EIN = "00-0000000",
        //            StreetAddress = "123 Main St.",
        //            StreetAddress2 = "",
        //            City = "Detroit",
        //            State = "MI",
        //            ZipCode = "48202"
        //        });
        }
    }
}
