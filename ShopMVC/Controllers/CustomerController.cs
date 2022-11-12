using Microsoft.AspNetCore.Mvc;

namespace ShopMVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var model = customerService.GetAllCustomersToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerModel model)
        {
            var id = customerService.AddCustomer(model);
            return View();
        }

        [HttpGet]
        public IActionResult AddNewAddressForClient(int customerId)
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewAddressForClient(AddressModel model)
        {

        }

        public IActionResult ViewCustomer(int CustomerId)
        {
            var customerModel = customerService.GetCustomerById(CustomerId);
            return View(Customermodel);
        }
    }
}
