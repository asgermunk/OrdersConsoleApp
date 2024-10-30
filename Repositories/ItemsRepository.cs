
using MongoDB.Driver;
using OrdersConsoleApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Repositories
{
   
        public class ItemsRepository
        {
            private string connectionString = "mongodb://localhost:27017";

            IMongoClient mongoClient;

            IMongoDatabase database;

            IMongoCollection<Item> collection;

            public ItemsRepository()
            {
                mongoClient = new MongoClient(connectionString);

                database = mongoClient.GetDatabase("OrdersDB");

                collection = database.GetCollection<Item>("Items");
            }

        public IEnumerable<Item> getItems()
        {
            var filter = Builders<Item>.Filter.Empty;
            return collection.Find(filter).ToList();
        }

        public Item getItem(string id)
        {
            var filter = Builders<Item>.Filter.Eq("ItemId", id);
            return collection.Find(filter).FirstOrDefault();

        }
        public  void  insertItem(Item item)
        {
            collection.InsertOne(item);
        }

        public UpdateResult addCategoryAllItems(string category)
        {
            var filter = Builders<Item>.Filter.Empty;
            var update = Builders<Item>.Update.Set("Category", category);
            return collection.UpdateMany(filter, update);
        }

    }
}

