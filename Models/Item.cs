using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Models
{
    public  class Item
    {
        public ObjectId  Id { get; set; }
        public string ItemId { get; set; }

        public string Name { get; set; }

        public double  Price { get; set; }
        public string Category { get; internal set; }
    }
}
