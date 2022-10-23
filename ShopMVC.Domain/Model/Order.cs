using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Domain.Model
{
    public class Order
    {
        public int Id { get; set; }
        public virtual Item Item { get; set; }
        public virtual Customer Customer { get; set; }

    }
}
