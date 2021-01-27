using System;

namespace HW
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> mydictionary = new MyDictionary<int,string>();

            mydictionary.Add(1, "Esra");
            mydictionary.Add(2, "Emre");
            mydictionary.Add(3, "Elif");
            mydictionary.Add(4, "Ayşe");
            mydictionary.Add(5, "Yusuf");
            mydictionary.Add(6, "Nur");

            mydictionary.ShowAll();

            Console.ReadLine();

        }
    }
}
