using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Razor.Models;

namespace Razor.Controllers
{
    public class HomeController : Controller
    {
        product myProduct = new product
        {
            ProductID = 1,
            Name = "Kayak",
            Description = "A boat for one person",
            Category = "Watersports",
            Price = 275M
        };
       
        public ActionResult Index()
        {
            return View(myProduct);
        }
        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }
        public ActionResult DemoExpression()
        {
            ViewBag.ProductCount = 1;
            ViewBag.ExpressShip = true;
            ViewBag.ApplyDiscount = false;
            ViewBag.Supplier = null;

            return View(myProduct);
        }
        public ActionResult DemoArray()
        {
            product[] array =
            {
                new product {Name = "Kayak", Price = 275M },
                new product {Name = "Lifejacket", Price = 48.95M },
                new product {Name = "Soccer ball", Price = 19.5M },
                new product {Name = "Corner flag", Price = 34.95M }
            };
            return View(array);
        }
    }
}