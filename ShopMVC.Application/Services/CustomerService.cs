using ShopMVC.Application.Interfaces;
using ShopMVC.Application.ViewModels.Customer;
using ShopMVC.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Application.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;

        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public ListCustomerForListVm GetAllCustomerToList()
        {
            var customers = _customerRepo.GetAllActiveCustomers();
            ListCustomerForListVm result = new ListCustomerForListVm();
            result.Customers = new List<CustomerToListVm>();
            foreach (var customer in customers)
            {
                var custVm = new CustomerToListVm()
                {
                    Id = customer.Id,
                    Name = customer.Name,
                };
                result.Customers.Add(custVm);
            }
            result.Count = result.Customers.Count;
            return result;
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            var customer = _customerRepo.GetCustomer(customerId);
            var customerVm = new CustomerDetailsVm();
            customerVm.Id = customer.Id;
            customerVm.Name = customer.Name;
            customerVm.Address = customer.Address;
            customerVm.City = customer.City;
            customerVm.EmailAddress = customer.EmailAddress;
            return customerVm;
        }
    }
}
