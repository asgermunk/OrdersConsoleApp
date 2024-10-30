using OrdersConsoleApp.Models;
using OrdersConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Controllers
{
    public class ItemsController
    {
       ItemsRepository repository;
        public ItemsController()
        {
            repository = new ItemsRepository();
        }

        public IEnumerable<Item> GetItems()
        {
            return repository.getItems();
        }

        public Item GetSelectedItem(string id)
        {
            return repository.getItem(id);
        }

        public void newitem(string  id, string name, double price,string category)
        {
            
            Item item = new Item() { ItemId = id, Name = name, Price = price, Category = category };
            repository.insertItem(item);

        }
    }
}
