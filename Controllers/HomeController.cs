using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TuotekuvastoApp.Models;
using Newtonsoft.Json;

namespace TuotekuvastoApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Product()

        {

            var products = GetProducts();

            return View(products);

        }

        private List<Product> GetProducts()

        {

            var json = System.IO.File.ReadAllText("wwwroot/products.json");

            return JsonConvert.DeserializeObject<List<Product>>(json);

        }


    }
}
