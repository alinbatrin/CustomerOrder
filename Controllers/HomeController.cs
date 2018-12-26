using Microsoft.AspNetCore.Mvc;
using CustomerOrder.Models;
using CustomerOrder.Services;

namespace CustomerOrder.Controllers
{
    public class HomeController : Controller
    {
        private ICustomerData _customerData;

        public HomeController(ICustomerData customerData)
        {
            _customerData = customerData;
        }

        public IActionResult Index()
        {
            var model = _customerData.GetAll();

            return View(model);
        }
    }
}
