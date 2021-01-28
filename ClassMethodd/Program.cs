using System;

namespace ClassMethodd
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.FirstName = "Viggo ";
            customer1.LastName = "Mortensen";
            customer1.Remainder = 400000;

            Customer customer2 = new Customer();
            customer2.FirstName = "Kit ";
            customer2.LastName = "Harrigton";
            customer2.Remainder = 60500;


            Customer customer3 = new Customer();
            customer3.FirstName = "Henry";
            customer3.LastName = "Calvin";
            customer3.Remainder = 90860;


            CustomerManager customerManager = new CustomerManager();
            customerManager.AddCustomer(customer1);


            Console.WriteLine("-------------------------");

            customerManager.DeleteCustomer(customer3);

            Console.WriteLine("-------------------------");

            customerManager.ListCustomer(customer2);
        }

        }
    }
