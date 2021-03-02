using System;
using System.Collections.Generic;
using System.Text;

namespace CodeCamp_ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer Added \nId : " + customer.Id + "\nName : " + customer.Name + "\nSurname : " + customer.Surname);
            Console.WriteLine("----------");
        }

        public void CustomerList(Customer[] customer)
        {
            Console.WriteLine("Customer List");
            foreach (var item in customer)
            {
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Surname);
            }

        }
    }
}
