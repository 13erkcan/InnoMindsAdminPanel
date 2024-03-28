using InnoMindsAdminPanel.Models;
using Microsoft.AspNetCore.Mvc;

namespace InnoMindsAdminPanel.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            
            var productList = new List<Product>
            {
                new Product { ProductId = 1, Name = "Laptop", Price = 1000, Description = "A powerful laptop." },
                new Product { ProductId = 2, Name = "Tablet", Price = 600, Description = "A convenient tablet." },
                
            };

          
            return View(productList);
        }
    }
}
