using System;

namespace CodeCamp_ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Tolga";
            customer1.Surname = "Sözbir";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Levent";
            customer2.Surname = "Sözbir";

            Customer[] customers = new Customer[] { customer1, customer2 };

            CustomerManager customerManager = new CustomerManager();

            customerManager.AddCustomer(customer1);
            customerManager.AddCustomer(customer2);

            customerManager.CustomerList(customers);

            Console.ReadKey();

            //Console.WriteLine("Hello Wordl!");
        }
    }
}
