using kursovProekt.Data;
using kursovProekt.Data.Models;
using kursovProekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace kursovProekt.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext db;


        public ProductController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult Add()
        {
            var model = new ProductViewModel();
            return View(model);
        }
         [HttpPost]

         public IActionResult Add(ProductViewModel input)
         {
            /* if(!ModelState.IsValid)
             {
                 return this.View(input);
             }*/
             Product product = new Product
             {
                 Name = input.Name,
                 Price = input.Price,
                 Description = input.Description,
                 Type = input.ProductType

             };
             this.db.Products.Add(product);
             this.db.SaveChanges();
            return Redirect("/");
         
        }

    }
}
