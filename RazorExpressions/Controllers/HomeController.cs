using RazorExpressions.Models;
using System.Web.Mvc;

namespace RazorExpressions.Controllers
{
    public class HomeController : Controller
    {

        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Atlantic",
            Description = "The 211.61ft /64.50m Custom 'Atlantic' was built in 2010 by Van der Graaf.",
            Category = "Sailing Yacht",
            Price = 22.00M
        };
        // GET: Home

        //Index method creates and populates the properties of product object
        public ActionResult Index()
        {
            return View(myProduct);
        }

        public ActionResult NameAndPrice()
        {
            return View(myProduct);
        }

        public ActionResult UseViewBag()
        {
            ViewBag.ApplyDiscount = false;
            ViewBag.ExpressShip = true;
            ViewBag.ProductCount = 5;
            ViewBag.Supplier = null;
            return View(myProduct);
        }

        public ActionResult DemoArray()
        {
            Product[] prodArray =
            {
                 new Product { Name = "K1", Price = 25.00M, Category = "River" },
                 new Product { Name = "K2", Price = 11.00M, Category = "Estuary" },
                 new Product { Name = "K3", Price = 29.00M, Category = "Lake" }
            };

            return View(prodArray);
        }
    }
}