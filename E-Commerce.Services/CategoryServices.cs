using E_Commerce.DAL.Management;
using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Services
{
    public class CategoryServices
    {
        private CategoryManagement categoryManagement;

        public CategoryServices()
        {
            categoryManagement = new CategoryManagement();
        }

        public List<Category> GetCategories() => categoryManagement.GetAllCategories();//kategori kontrolünü yap sonrasında.
       
    }
}
