using OrdersConsoleApp.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Consoles_Pages
{
    public  class CustomersConsole
    {
        static CustomersController controller = new CustomersController();
        public static void manageCustomers()
        {

            bool running = true;
            while (running)
            {
                Console.Clear();  // Clears the console screen
                Console.WriteLine("=== Managing Customers ===");
                Console.WriteLine("1. Option 1 - Add Customer");
                Console.WriteLine("2. Option 2 - Get all customers");
                Console.WriteLine("3. Option 3 - Delete Customer");
                Console.WriteLine("0. Exit");
                
                Console.Write("Please select an option: ");
                string input = Console.ReadLine();
                
                switch (input)
                {
                    case "1":
                        Console.WriteLine("Enter the customer id");
                        int cid = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter the name");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter the email");
                        string email = Console.ReadLine();
                        Console.WriteLine("sending data to the controller");
                        controller.newCustomer(cid, name, email);
                        break;
                    case "2":
                        var customers = controller.GetCustomers();
                        foreach (var customer in customers)
                        {
                            Console.WriteLine("name:" + " " + customer.Name);
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Enter the customer id");
                        string cemail = Console.ReadLine();
                        Console.WriteLine("sending data to the controller");
                        //controller.removeCustomer(cemail);
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
