using ShopMVC.Application.ViewModels.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Application.Interfaces
{
    public interface ICustomerService
    {
        ListCustomerForListVm GetAllCustomerToList();
        int AddCustomer(NewCustomerVm customer);
        CustomerDetailsVm GetCustomerDetails(int customerId);

    }
}
