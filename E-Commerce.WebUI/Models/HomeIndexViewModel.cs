using E_Commerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_Commerce.WebUI.Models
{
    public class HomeIndexViewModel
    {
        public HomeIndexViewModel()
        {
            Products = new List<Product>();
            
        }

        public List<Product> Products { get; set; }

      
    }
}