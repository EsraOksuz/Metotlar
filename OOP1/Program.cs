using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CathegoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product {Id =2, CathegoryId=5,ProductName="Kalem",UnitsInStock=5,UnitPrice=35 };
            //Pascal case   //camelCase
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);


           
        }
    }
}
