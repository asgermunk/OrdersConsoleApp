using OrdersConsoleApp.Models;
using OrdersConsoleApp.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersConsoleApp.Controllers
{
    public  class CustomersController
    {
        CustomersRepository repository;
        public CustomersController() 
        { 
            repository= new CustomersRepository();  
        }
        
        public IEnumerable<Customer> GetCustomers()
        {
            return repository.getCustomers();
        }

        public Customer GetCustomer(string email)
        {

            return repository.getCustomerByEmail(email);
        }

        public void  newCustomer( int id, string name,  string email)
        {
            Customer customer = new Customer() { CustomerId = id, Name = name, Email = email };
            repository.insertCustomer(customer);
        }

       
    }
}
