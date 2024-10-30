using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Models
{
    public  class Order
    { 
        public ObjectId  Id { get; set; }
        public DateTime  Date { get; set; }       
        public Customer Customer { get; set; }
        public List<Item>? ShoppingCart { get; set;}= new List<Item>();

        public double  calculateTotalAmount()
        {
            double sum = 0;
            foreach (var item in ShoppingCart)
            {
                sum += (int)item.Price;
            }
            return sum;
        }

        public void AddItem(Item item)
        {
            ShoppingCart.Add(item);
        }
    }
}
