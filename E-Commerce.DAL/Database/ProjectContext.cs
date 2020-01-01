using E_Commerce.DAL.Mappings;
using E_Commerce.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace E_Commerce.DAL.Database
{
    public class ProjectContext: DbContext
    {
        public ProjectContext()
        : base("defaultConnection")
        {
            var ensureDLLIsCopied =
           System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CategoryMappings());
            modelBuilder.Configurations.Add(new ProductMappings());
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Product { get; set; }


    }
}
