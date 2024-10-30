using OrdersConsoleApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Consoles_Pages
{
    public class OrdersConsole
    {
        static OrdersController ordersController = new OrdersController();
        static ItemsController itemsController = new ItemsController();
        static CustomersController customersController = new CustomersController();
        public static void manageOrders()
        {

            bool running = true;
            while (running)
            {
                Console.Clear();  // Clears the console screen
                Console.WriteLine("=== Managing Orders ===");
                Console.WriteLine("1. Option 1 - Create an Order");
                Console.WriteLine("2. Option 2 - Get all orders");
                Console.WriteLine("3. Option 3 - Delete Order");
                Console.WriteLine("0. Exit");
                Console.Write("Please select an option: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("-------------You want to place an order-------");
                        Console.WriteLine("Here are the available items");
                        var items= itemsController.GetItems();
                        foreach (var item in items)
                        {
                            Console.WriteLine("ItemId="+item.ItemId + "\t"+ "Name="+ item.Name);
                        }
                        while (running)
                        {
                            Console.WriteLine("Enter an Item Id or Enter to exit");
                            string itemid = Console.ReadLine();
                            Console.WriteLine("You entered\t" +  itemid);
                            var selecteditem = itemsController.GetSelectedItem(itemid);

                            if (selecteditem != null)
                            {
                                ordersController.addToCart(selecteditem);
                                int Count = ordersController.Count;
                                Console.WriteLine($"You buy {Count} items \t and you should pay" + ordersController.getCost());
                            }
                            else
                            {
                                running = false;
                                break;
                            }
                        }                
                        Console.WriteLine("Enter your email");
                        string email= Console.ReadLine();
                        var customer=customersController.GetCustomer(email);
                        Console.WriteLine("Placing order");
                        ordersController.newOrder(customer);                      
                        break;                    
                }
                if (running)
                {
                    Console.WriteLine("\nPress any key to return to the main menu...");
                    Console.ReadKey();
                }
            }
        }
    }
}
