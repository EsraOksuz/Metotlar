using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(1, "Esra", 25);
            customerManager.Add(2, "Ali", 15);
            customerManager.Add(3, "Ayşe", 29);
            customerManager.Add(4, "Emre", 16);
            customerManager.Add(5, "Yusuf", 35);


            customerManager.ShowCustomers();


            Console.ReadLine();

        }
    }
}
