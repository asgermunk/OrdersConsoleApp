using OrdersConsoleApp.Consoles_Pages;
using OrdersConsoleApp.Controllers;
using System.Runtime.CompilerServices;

internal class Program
{
    private static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();  // Clears the console screen
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. Option 1 - CRUD  Customers");
            Console.WriteLine("2. Option 2 - CRUD  Items");
            Console.WriteLine("3. Option 3 - CRUD Orders");
            Console.WriteLine("0. Exit");
            Console.Write("Please select an option: ");

            // Get the user input and validate it
            string input = Console.ReadLine();
            switch (input)
            {
                case "1":
                    CustomersConsole.manageCustomers();
                    break;
                case "2":
                    ItemsConsole.manageItems();
                    break;
                case "3":
                    OrdersConsole.manageOrders();
                    break;
                case "0":
                    running = false;
                    Console.WriteLine("Exiting the application...");
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
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