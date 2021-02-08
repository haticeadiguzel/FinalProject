using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
//4.
namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll(); //Product burda farklı bir katmandan gelecek.
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); //Bu üünleri kategroiye göre filtrele demektir.

    }
}
