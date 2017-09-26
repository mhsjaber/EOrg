using EOrg.Core.Membership;
using EOrg.Core.Shop;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EOrg.Core
{
    public class CoreContext : DbContext
    {
        public CoreContext()
            : base("name=DefaultConnection")
        {
            Database.SetInitializer<CoreContext>(null);
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        public virtual DbSet<Color> Color { get; set; }
        public virtual DbSet<Sell> Sell { get; set; }
        public virtual DbSet<Installment> Installmet { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
