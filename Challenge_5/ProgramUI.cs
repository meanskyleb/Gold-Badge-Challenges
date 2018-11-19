using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class ProgramUI
    {
        CustomerRepository _customerRepo = new CustomerRepository();
        List<Customer> _customerList;

        public void Run()
        {
            _customerList = _customerRepo.GetCustomersList();
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
                        Console.ReadLine();
                        break;
                    case 2:
                        CreateCustomer();
                        break;
                    case 3:
                        UpdateCustomerType();
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
            foreach(Customer customer in _customerList)
            {
                Console.WriteLine(customer.FirstName);
                Console.WriteLine(customer.LastName);
                Console.WriteLine(customer.Email);
                Console.WriteLine(customer.TypeOfCustomer);
            }
        }

        private void CreateCustomer()
        {
            Console.WriteLine("what is the customer's first name?");
            var firstName = Console.ReadLine();

            Console.WriteLine("what is the customer's last name?");
            var lastName = Console.ReadLine();

            Console.WriteLine("what is the customer's email?");
            var email = Console.ReadLine();

            Console.WriteLine("please enter type of customer: ");
            
            var type = _customerRepo.GetType(Console.ReadLine());

            Customer newCustomer = new Customer()
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
            };
            _customerList.Add(newCustomer);    
        }

        private void UpdateCustomerType()
        {
            ShowCustomers();
            Console.WriteLine("please enter the last name of the customer you would like to update:");
            var lastName = Console.ReadLine();

            foreach (Customer c in _customerList)
            {

                if (c.LastName == lastName)
                {
                    Console.WriteLine("please enter the customer type:");
                    var input = Console.ReadLine();
                    c.TypeOfCustomer = _customerRepo.GetType(input);
                }

            }

        }

        private void RemoveCustomer()
        {
            ShowCustomers();
            Console.WriteLine("Please enter the last name of the customer you want to remove:");
            var customer = Console.ReadLine();
            _customerRepo.RemoveCustomerFromList(customer);

            Console.WriteLine("updated customer list:");
            ShowCustomers();
            Console.ReadLine();
        }
       
    }
}
