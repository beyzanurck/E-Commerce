using E_Commerce.DAL.Management;
using E_Commerce.Entities;
using System.Collections.Generic;

namespace E_Commerce.Services
{
    public class ProductServices
    {
        private ProductManagement productManagement;

        public ProductServices()
        {
            productManagement = new ProductManagement();
        }

        public List<Product> GetProducts() => productManagement.GetAllProduct();

    }
}
