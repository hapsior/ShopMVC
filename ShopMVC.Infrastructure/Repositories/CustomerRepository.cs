using ShopMVC.Domain.Interfaces;
using ShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Infrastructure.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public IQueryable<Customer> GetAllActiveCustomers()
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
