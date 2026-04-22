using kursovProekt.Data;
using kursovProekt.Models;
using Microsoft.AspNetCore.Mvc;

namespace kursovProekt.Controllers
{
    public class OrderController : Controller
    {
        private readonly ApplicationDbContext db;

        public OrderController(ApplicationDbContext db)
        {
            this.db = db;
        }
        public IActionResult All()
        {
            List<OrderViewModel> model = db.Orders.Select(x => new OrderViewModel
            {
                Id = x.Id,
                UserName = x.User.UserName,
                ProductName = x.Product.Name,
                OrderedOn = x.OrderedOn
                
            }
            ).ToList();
            return View(model);
        }
        public IActionResult Create()
        {
            return Redirect("Home/Index");
        }
    }
}
