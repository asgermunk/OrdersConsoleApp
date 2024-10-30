using MongoDB.Driver;
using OrdersConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Repositories
{
   public class CustomersRepository
    {
        private string connectionString = "mongodb://localhost:27017";

        IMongoClient mongoClient;

        IMongoDatabase database;

        IMongoCollection<Customer> collection;

        public CustomersRepository()
        {
            mongoClient = new MongoClient(connectionString);

            database = mongoClient.GetDatabase("OrdersDB");

            collection = database.GetCollection<Customer>("Customers");
        }

        public  IEnumerable<Customer> getCustomers()
        {
            var filter = Builders<Customer>.Filter.Empty;
            return collection.Find(filter).ToList();
        }
        
        public  void insertCustomer(Customer customer)
        {
            collection.InsertOne(customer);   
        }

        public Customer getCustomerByEmail(string email)
        {
            var filter = Builders<Customer>.Filter.Eq("Email", email);
            return collection.Find(filter).FirstOrDefault();
        }
    }
}
