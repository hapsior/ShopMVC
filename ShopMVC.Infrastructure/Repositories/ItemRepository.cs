using ShopMVC.Domain.Interfaces;
using ShopMVC.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopMVC.Infrastructure.Repositories
{
    public class ItemRepository : IItemRepository
    {
        private readonly Context _context;

        public ItemRepository(Context context)
        {
            _context = context;
        }

        public void DeleteItem(int itemId)
        {
            var item = _context.Items.Find(itemId);
            if (item != null)
            {
                _context.Items.Remove(item);
                _context.SaveChanges();
            }
        }

        public int AddItem(Item item)
        {
            _context.Add(item);
            // return _context.SaveChanges(); //To check how works
            _context.SaveChanges();
            return item.Id;
        }

        public IQueryable<Item> GetItemsByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return _context.Items;
            }

            return _context.Items.Where(x => x.Name.Contains(name));
        }

        public IQueryable<Item> GetItemById(int itemId)
        {
            return _context.Items.Where(x => x.Id == itemId);
        }
    }
}
