using E_Commerce.DAL.Database;
using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public Category AddCategory(Category category )
        {
            var categories = database.Category.Add(category);
            database.SaveChanges();   
            return category;
        }


        public Category GetCategory(int id)
        {
            var categories = database.Category.FirstOrDefault(i => i.Id == id);
            return categories;
        }

        public void UpdateCategory(int id, Category category)
        {
            database.Entry(category).State = EntityState.Modified;
            database.SaveChanges();
        }

        public void deletedCategory(int id,Category category)
        {
            var ctgry = new Category { Id = id };
            //var categories = database.Category.FirstOrDefault(i => i.Id == id);
            //database.Category.Remove(ctgry);
            database.Category.Attach(ctgry);
            database.Entry(ctgry).State = EntityState.Deleted;
            database.SaveChanges();
        }
    }
}
