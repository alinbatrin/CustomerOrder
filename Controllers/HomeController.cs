using Microsoft.AspNetCore.Mvc;
using CustomerOrder.Models;
namespace CustomerOrder.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Hello from the HomeController $$");
            var model = new Customer { ID = 1, Name = "Ion" };

            return new ObjectResult(model);
        }
    }
}
