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

        public IActionResult All()
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

        public IActionResult Details(int id)
        {
            Product product = db.Products.FirstOrDefault(c => c.Id == id);
            ProductViewModel model = new ProductViewModel
            {
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ProductType = product.Type
            };
            return View(model);
        }
    }
}
