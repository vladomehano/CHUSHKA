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
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            ProductViewModel model = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ProductType = product.Type
            };
            return View(model);
        }

        public IActionResult Edit(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            ProductViewModel model = new ProductViewModel
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Description = product.Description,
                ProductType = product.Type
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(ProductViewModel model)
        {
            Product product = db.Products.FirstOrDefault(x => model.Id == x.Id);
            product.Name = model.Name;
            product.Price = model.Price;
            product.Description = model.Description;
            product.Type = model.ProductType;

            db.SaveChanges();
            return this.Redirect("/Home/Index");
        }

        public IActionResult Delete(int id)
        {
            Product product = db.Products.FirstOrDefault(x => x.Id == id);
            db.Products.Remove(product);
            db.SaveChanges();
            return Redirect("/Home/Index");
        }
    }
}
