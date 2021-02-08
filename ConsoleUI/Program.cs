using Business.Concrete;
using DataAccess.Concrete.InMemory;
using System;
//8.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new InMemoryProductDal());//Parantez içindeki zaten sana hata verip ne yazman gerektiğini söylüyor.

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

        }
    }
}
