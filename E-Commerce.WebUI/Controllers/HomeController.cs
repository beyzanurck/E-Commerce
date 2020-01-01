using E_Commerce.Entities;
using E_Commerce.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly CategoryServices categoryServices;
        private readonly ProductServices productServices;

        public HomeController()
        {
            categoryServices = new CategoryServices();
            productServices = new ProductServices();
        }

        [HttpGet]
        public ActionResult Index()
        {
            List<Product> products = productServices.GetProducts();
            return View(products);
        }
    }
}