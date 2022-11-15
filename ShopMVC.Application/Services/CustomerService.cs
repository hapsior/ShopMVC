using AutoMapper;
using AutoMapper.QueryableExtensions;
using ShopMVC.Application.Interfaces;
using ShopMVC.Application.ViewModels.Customer;
using ShopMVC.Domain.Interfaces;
using ShopMVC.Domain.Model;
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
        private readonly IMapper _mapper;

        public int AddCustomer(NewCustomerVm customer)
        {
            throw new NotImplementedException();
        }

        public ListCustomerToList GetAllCustomerToList()
        {
            var customers = _customerRepo.GetAllActiveCustomers()
                .ProjectTo<CustomerToListVm>(_mapper.ConfigurationProvider).ToList();

            var customerList = new ListCustomerToList()
            {
                Customers= customers,
                Count= customers.Count
            };

            return customerList;
        }

        public CustomerDetailsVm GetCustomerDetails(int customerId)
        {
            var customer = _customerRepo
                .GetCustomer(customerId).ProjectTo<CustomerDetailsVm>(_mapper.ConfigurationProvider).ToList();

        }
    }
}
