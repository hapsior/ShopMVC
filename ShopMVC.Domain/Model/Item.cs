using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Domain.Model
{
    [Table("ShopItem")]
    public class Item
    {
        public int Id { get; set; }
        public string ?Name { get; set; }
        public byte[] ?Image { get; set; }
        public int Quantity { get; set; }
    }
}
