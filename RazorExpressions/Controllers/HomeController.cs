using RazorExpressions.Models;
using System.Web.Mvc;

namespace RazorExpressions.Controllers
{
    public class HomeController : Controller
    {

        Product myProduct = new Product
        {
            ProductID = 1,
            Name = "Kayak",
            Description = "A boat for 2 people",
            Category = "Lake",
            Price = 22.00M
        };
        // GET: Home

            //Index method creates and populates the properties of product object
        public ActionResult Index()
        {
            return View(myProduct);
        }
    }
}