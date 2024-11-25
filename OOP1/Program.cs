using System;

namespace OOP1
{
    class Program
    {

        static void Main(string[] args)
        {

            Product product1 = new Product();
            product1.Id = 1;
            //2 --> Mobilya kategorisine denk geliyor arka planda
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice  = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product
            {
                Id = 2,
                CategoryId = 5,
                UnitInStock = 5,
                ProductName = "Kalem",
                UnitPrice = 35,
            };



            //Pascal case  //camelCase
            //Case sensitive
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);

             


        }
    }
}