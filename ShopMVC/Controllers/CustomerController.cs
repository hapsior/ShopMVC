using Microsoft.AspNetCore.Mvc;
using ShopMVC.Application.Interfaces;

namespace ShopMVC.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerService _customerService;
        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        public IActionResult Index()
        {
            var model = _customerService.GetAllCustomerToList();
            return View(model);
        }
        [HttpGet]
        public IActionResult AddCustomer()
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddCustomer(CustomerModel model)
        //{
        //    var id = _customerService.AddCustomer(model);
        //    return View();
        //}

        [HttpGet]
        public IActionResult AddNewAddressForClient(int customerId)
        {
            return View();
        }

        //[HttpPost]
        //public IActionResult AddNewAddressForClient(AddressModel model)
        //{
        //    return View(model);
        //}

        public IActionResult ViewCustomer(int CustomerId)
        {
            var customerModel = _customerService.GetCustomerDetails(CustomerId);
            return View(customerModel);
        }
    }
}
