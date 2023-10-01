using Microsoft.AspNetCore.Mvc;
using Prototype00_MVC.Models;

namespace Prototype00_MVC.Controllers
{
    public class ProductController : Controller
    {

        List<Product> products = new List<Product>();
        public IActionResult Index()
        {
            Populate();
            return View(products);
        }

        public void Populate()
        {
            products.Add(new Product("P123", "Milk", 25.89));
            products.Add(new Product("P246", "Bread", 18.89));
            products.Add(new Product("p369", "Butter", 28.89));
            products.Add(new Product("p445", "Bacon", 60.89));
        }
    }
}
