using E_Commerce.DAL.Database;
using E_Commerce.Entities;
using System.Collections.Generic;
using System.Linq;

namespace E_Commerce.DAL.Management
{
    public class ProductManagement
    {
        private ProjectContext database;

        public ProductManagement()
        {
            database = new ProjectContext();
        }

        public List<Product> GetAllProduct()
        {
            var products = database.Product.Include("Category").ToList();
            return products;
        }

    }
}
