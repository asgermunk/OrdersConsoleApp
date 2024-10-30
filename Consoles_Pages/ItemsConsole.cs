using OrdersConsoleApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Consoles_Pages
{
    internal class ItemsConsole
    {
        static ItemsController itemController = new ItemsController();
        public static void manageItems()
        {

            bool running = true;
            while (running)
            {
                Console.Clear();  // Clears the console screen
                Console.WriteLine("=== Managing Items ===");
                Console.WriteLine("1. Option 1 - Add Item");
                Console.WriteLine("2. Option 2 - Get all Items");
                Console.WriteLine("3. Option 3 - Delete Item");
                Console.WriteLine("0. Exit");
                Console.Write("Please select an option: ");

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter the item id");
                        string itemId = Console.ReadLine();
                        Console.WriteLine("Enter the name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the price");
                        double price = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the category");
                        string category = Console.ReadLine();
                        Console.WriteLine("sending data to the controller");
                       
                        itemController.newitem(itemId, name, price,category);
                        break;
                    case "2":
                        var items = itemController.GetItems();
                        foreach (var item in items)
                        {
                            Console.WriteLine("name" + " " + item.Name);    
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Enter the customer id");
                        string cemail = Console.ReadLine();
                        Console.WriteLine("sending data to the controller");
                       // controller.removeCustomer(cemail);
                        break;
                    

                    case "0":
                        running = false;
                        Console.WriteLine("Exiting the application...");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please try again.");
                        break;
                }
            }
        }
    }
}
