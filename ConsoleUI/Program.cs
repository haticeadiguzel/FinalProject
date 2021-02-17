using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;
//8.
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();

            //CategoryTest();

            ProductManager productManager = new ProductManager(new EfProductDal());//Parantez içindeki zaten sana hata verip ne yazman gerektiğini söylüyor.

            foreach (var product in productManager.GetProductDetails())
            {
                Console.WriteLine(product.ProductName + "/" + product.CategoryName);
            }

        }

        private static CategoryManager CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName+"/"+category.CategoryId);
            }

            return categoryManager;
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());//Parantez içindeki zaten sana hata verip ne yazman gerektiğini söylüyor.

            foreach (var product in productManager.GetByUnitPrice(40, 100))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
