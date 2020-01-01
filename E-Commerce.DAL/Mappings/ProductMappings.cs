using E_Commerce.Entities;
using System.Data.Entity.ModelConfiguration;

namespace E_Commerce.DAL.Mappings
{
    public class ProductMappings : EntityTypeConfiguration<Product>
    {
        public ProductMappings()
        {
            ToTable("Products", "eCommerce");
        }

    }


}
