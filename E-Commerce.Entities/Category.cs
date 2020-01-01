using System.Collections.Generic;

namespace E_Commerce.Entities
{
    public class Category
    {
        public Category()
        {
            Products = new List<Product>(); //POCO
        }

        public int Id { get; set; }

        public string CategoryName { get; set; }

        public List<Product> Products { get; set; }
    }
}
