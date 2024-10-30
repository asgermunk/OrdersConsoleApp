using OrdersConsoleApp.Models;
using OrdersConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Controllers
{
    public  class OrdersController
    {

        Order _order = new Order();
        public  int Count{ get; set; }

        OrdersRepository repository;
        public OrdersController()
        {
            repository= new OrdersRepository();
        }
        public void addToCart(Item item)
        {
          _order.AddItem(item);
          Count = _order.ShoppingCart.Count;
        }

        public double getCost()
        {        
            return _order.calculateTotalAmount();
        }
        public void newOrder(Customer customer)
        {
             Order order = new Order() { Customer = customer ,   Date=DateTime.Now ,  ShoppingCart=_order.ShoppingCart };
             repository.insertOneOrder(order);

        }

        
    }
}
