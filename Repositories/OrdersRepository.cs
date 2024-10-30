
using MongoDB.Driver;
using OrdersConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Repositories
{
    public  class OrdersRepository
    {
        private string connectionString = "mongodb://localhost:27017";

        IMongoClient mongoClient;

        IMongoDatabase database;

        IMongoCollection<Order> collection;

        public OrdersRepository()
        {
            mongoClient = new MongoClient(connectionString);

            database = mongoClient.GetDatabase("OrdersDB");

            collection = database.GetCollection<Order>("Orders");
        }

            public void insertOneOrder(Order order)
            {
                collection.InsertOne(order);
        }
            

        }
}
