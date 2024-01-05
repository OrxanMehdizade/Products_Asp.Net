using Microsoft.AspNetCore.Mvc;
using ProductsAsp.Models;

namespace ProductsAsp.Controllers
{
    public class ProductController : Controller
    {
        static List<Product> products = new() {

            new Product { ProductName ="Colla", Description = "harmful",Price=2.50},
            new Product{ ProductName = "Fanta", Description = "harmful",Price=2.20},
            new Product{ ProductName = "Cappy", Description = "harmful",Price=3},
            new Product{ ProductName = "Badamli", Description = "harmful",Price=2.60},
            new Product{ ProductName = "Sirab", Description = "harmful",Price=1},
            new Product{ ProductName = "Red Bull", Description = "harmful",Price=4.50},
            new Product{ ProductName = "Hell", Description = "harmful",Price=3.70},
        };


        [HttpGet]
        public IActionResult GetAll()
        {
            return View(products);
        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            var product=products.FirstOrDefault(p=>p.Id==id);
            return View(product);
        }

        [HttpGet]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddProduct(Product model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            products.Add(model);

            return RedirectToAction("GetAll");
        }


    }
}
