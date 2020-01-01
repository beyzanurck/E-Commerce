using E_Commerce.Entities;
using System.Data.Entity.ModelConfiguration;


namespace E_Commerce.DAL.Mappings
{

    public class CategoryMappings: EntityTypeConfiguration<Category>
    {
        public CategoryMappings()
        {
            ToTable("Categories", "eCommerce");
        }

    }


}
