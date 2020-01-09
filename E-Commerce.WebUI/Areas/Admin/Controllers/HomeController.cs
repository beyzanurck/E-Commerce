using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace E_Commerce.WebUI.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]// GET: Admin/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}