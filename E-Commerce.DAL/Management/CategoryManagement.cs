using E_Commerce.DAL.Database;
using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.DAL.Management
{
    public class CategoryManagement
    {
        private ProjectContext database;

        public CategoryManagement()
        {
            database = new ProjectContext();
        }

        public List<Category> GetAllCategories()
        {
            var categories = database.Category.ToList();
            return categories;
        }

    }
}
