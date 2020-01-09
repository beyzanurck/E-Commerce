using E_Commerce.Entities;
using E_Commerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.WebUI.Areas.Admin.Controllers
{
    public class CategoryController : Controller
    {
        private CategoryServices _categoryServices;

        public CategoryController()
        {
            _categoryServices = new CategoryServices();
        }


        [HttpGet]// GET: Admin/Category
        public ActionResult Index()
        {
            var categories = _categoryServices.GetCategories();
            return View(categories);
        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("","the category already has been here");
                return View(category);
            }
            _categoryServices.AddCategory(category);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var category = _categoryServices.GetCategory(id);
            return View(category);
        }


        [HttpPost]
        public ActionResult Delete(int id, Category category)
        {
            _categoryServices.deletedCategory(id, category);
            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public ActionResult Edit(int id)
        {
            var categoryId = _categoryServices.GetCategory(id);
            return View(categoryId);
        }

        [HttpPost]
        public ActionResult Edit(int id, Category category)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "dsdasd");
                return View(category);
            }
            _categoryServices.updatedCategory(id, category);
            return RedirectToAction(nameof(Index));
        }


    }
}