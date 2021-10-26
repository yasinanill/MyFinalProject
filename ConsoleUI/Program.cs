using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
using System.Collections.Generic;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());


            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.CategoryId);

            }
            foreach (var product in productManager.GetByUnitPrice(12,56))
            {
                Console.WriteLine(product.ProductName);
                Console.WriteLine(product.CategoryId);

            }


        }
    }
}
