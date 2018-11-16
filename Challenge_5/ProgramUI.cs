using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class ProgramUI
    {
        CustomerRepository _customerCustomer = new CustomerRepository();
        List<Customer> _customerList = new List<Customer>();

        public void Run()
        {
            RunMainMenu();
        }

        private void RunMainMenu()
        {
            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Welcome to Komodo Insurance, please choose an action:" +
                    "\n1. Show All Customers" +
                    "\n2. Create Customer" +
                    "\n3. Update Customer" +
                    "\n4. Remove Customer" +
                    "\n5. Exit");

                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        ShowCustomers();
                        break;
                    case 2:
                        CreateCustomer();
                        break;
                    case 3:
                        UpdateCustomer();
                        break;
                    case 4:
                        RemoveCustomer();
                        break;
                    case 5:
                        isRunning = false;
                        Console.WriteLine("exit complete");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("invalid response");
                        Console.ReadLine();
                        break;

                }
            }
        }

        private void ShowCustomers()
        {
            List<Customer> customerList = _customerCustomer.GetCustomersList();
            foreach(Customer customer in customerList)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.TypeOfCustomer);
            }
        }

        private void CreateCustomer()
        {

        }
    }
}
