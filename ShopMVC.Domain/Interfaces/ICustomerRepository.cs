using ShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Domain.Interfaces
{
    public interface ICustomerRepository
    {
        IQueryable<Customer> GetAllActiveCustomers();
        Customer GetCustomer(int customerId);
    }
}
