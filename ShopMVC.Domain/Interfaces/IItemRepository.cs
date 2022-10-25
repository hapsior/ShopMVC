using ShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Domain.Interfaces
{
    public interface IItemRepository
    {
        public void DeleteItem(int itemId);
        public int AddItem(Item item);
        public IQueryable<Item> GetItemsByName(string name);
        public IQueryable<Item> GetItemById(int itemId);
    }
}
