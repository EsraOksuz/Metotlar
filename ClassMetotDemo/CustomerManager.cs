using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();

        public void Add(int id, string name, int age)
        {
            customers.Add(new Customer()
            {
                Id = id,
                Name = name,
                Age = age,
            });

        }

        public void ShowCustomers()
        {
            foreach (Customer customs in customers)
            {
                Console.WriteLine("--------");
                Console.WriteLine(customs.Id + " : " + customs.Name + " -> " + customs.Age);
            }
        }
    }
}
