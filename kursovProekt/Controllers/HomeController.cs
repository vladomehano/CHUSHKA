using kursovProekt.Data;
using kursovProekt.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace kursovProekt.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;


        public HomeController(ApplicationDbContext db)
        {
            this.db = db;
        }
        private readonly ILogger<HomeController> _logger;

        

        public IActionResult Index()
        {
            List<ProductViewModel> model = db.Products.Select(x => new ProductViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Price = x.Price,
                Description = x.Description,
                ProductType = x.Type
            }
            ).ToList();
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
