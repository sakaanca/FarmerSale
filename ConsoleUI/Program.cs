// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManger = new ProductManager(new EfProductDal());
            foreach (var product in productManger.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}