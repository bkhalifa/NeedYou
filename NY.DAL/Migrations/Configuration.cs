namespace NY.DAL.Migrations
{
    using NY.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DepotContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DepotContext context)
        {


            context.Persons.AddOrUpdate(x => x.Id,
         new Person() { Id = 1, Name = "Bilel",LastName="Ben Khalifa",DateOfBirth= new DateTime(1983, 07, 18) },
         new Person() { Id = 2, Name = "Asma" ,LastName="Latrous",DateOfBirth=new DateTime(1988,03,18)},
         new Person() { Id = 3, Name = "Myriam",LastName="BEn Khalifa",DateOfBirth=new DateTime(2016,03,09) }
         );

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
