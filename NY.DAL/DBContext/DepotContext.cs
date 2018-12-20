using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using NY.Models;

namespace NY.DAL
{
    public class DepotContext: DbContext
    {
        public DbSet<Person> Persons { get; set; }





        public DepotContext() :base("NeedYouDbContext")
        {
            
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<int>()
                .Where(x => x.Name == "Key")
                .Configure(x => x.IsKey().HasColumnOrder(1));

        }

      

    }


}
