﻿namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            //her iki şekilde de yazılabilir

            Product product2 = new Product {Id=2,CategoryId=5,
                ProductName="Kalem", UnitInStock=5, UnitPrice=35 };

            //PascalCase   // camelCase
            //case sensitive - küçük-büyük harf duyarlı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


          


        }
    }



}