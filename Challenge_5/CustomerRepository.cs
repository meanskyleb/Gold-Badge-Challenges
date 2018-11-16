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

        public void RemoveCustomerFromList(Customer customer)
        {
            _customerList.Remove(customer);
        }

        public void UpdateCustomerInfo(Customer customer)
        {
            customer.TypeOfCustomer = CustomerType.Current;
        }

    }
}
