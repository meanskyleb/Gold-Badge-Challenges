using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    class CustomerRepository
    {
        List<Customer> _customerList = new List<Customer>();

        public void AddCustomerToList(Customer customer)
        {
            _customerList.Add(customer);
        }

        public List<Customer> GetCustomersList()
        {
            return _customerList;
        }

        public void RemoveCustomerFromList(string customer)
        {
            _customerList.Remove(customer);
        }

        public void UpdateCustomerInfo(Customer customer)
        {
            customer.TypeOfCustomer = CustomerType.Current;
        }

        public CustomerType GetType(string input)
        {
            CustomerType type;
            switch (input)
            {
                case "Current":
                case "current":
                    type = CustomerType.Current;
                    break;
                case "Past":
                case "past":
                    type = CustomerType.Past;
                    break;
                default:
                    type = CustomerType.Potential;
                    break;
            }
            return type;
        }

        public void EmailBasedOnCustomer(CustomerType customer)
        {
            CustomerType type;
            switch (customer)
            {
                case CustomerType.Current:
                    string = "Thank you for your work with us. We appreciate your loyalty. Here's a coupon.";
                        break;
                case CustomerType.Past:
                    string = "It's been a long time since we've heard from you, we want you back";
                        break;
                case CustomerType.Potential:
                    string = "We currently have the lowest rates on Helicopter Insurance!";
                    break;
            }
        }
    }
}
