using EOrg.Core.Membership;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
