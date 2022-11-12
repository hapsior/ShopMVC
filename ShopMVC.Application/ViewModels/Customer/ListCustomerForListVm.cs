using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Application.ViewModels.Customer
{
    public class ListCustomerForListVm
    {
        public List<CustomerToListVM> Customers { get; set; }
        public int Count { get; set; }

    }
}
