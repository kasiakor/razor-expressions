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
    }
}