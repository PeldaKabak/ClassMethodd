using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodd
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Added new customer:" + customer.FirstName + " " + customer.LastName + " " + customer.Remainder);
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Deleted customer:" + customer.FirstName + " " + customer.LastName + " " + customer.Remainder);
        }

        public void ListCustomer(Customer customer)
        {
            Console.WriteLine("Customer First Name :" + customer.FirstName);
            Console.WriteLine("Customer Last Name :" + customer.LastName);
            Console.WriteLine("Customer Remainder :" + customer.Remainder);
        }
    }
}
