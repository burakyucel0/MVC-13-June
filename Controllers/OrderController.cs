using Microsoft.AspNetCore.Mvc;
using MVCdbConnect.Models.ORM;

namespace MVCdbConnect.Controllers
{
    public class OrderController : Controller
    {
        SiemensContext siemensContext = new SiemensContext();
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Order order)
        {
            siemensContext.Add(order);
            siemensContext.SaveChanges();

            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var order = siemensContext.Orders.FirstOrDefault(q => q.Id == id);

            return View(order);
        }
        [HttpPost]
        public IActionResult Update(Order order)
        {
            siemensContext.Update(order);
            siemensContext.SaveChanges();

            return RedirectToAction("GetAll");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Order> orders = siemensContext.Orders.ToList();

            return View(orders);
        }
   
       [HttpGet]
        public IActionResult Delete(int id)
        {
            var orderDel = siemensContext.Orders.FirstOrDefault(q => q.Id == id);

            siemensContext.Remove(orderDel);
            siemensContext.SaveChanges();
            return RedirectToAction("GetAll");
        }
        [HttpPost]
        public IActionResult Delete()
        {

            return RedirectToAction("GetAll");
        }
    }
}
