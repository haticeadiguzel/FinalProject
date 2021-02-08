using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//5.
namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal //implementasyonu ekleriz
    {
        List<Product> _products; //Tüm metotların dışında kullandığımızda buna global değişken denir. _ ile başlar.
        public InMemoryProductDal() //ctor yaparız.
        {
            _products = new List<Product> //Listeyi newleyip içine ürünlerimizi ekleriz.
            {
                //Burası sanki Oracle, Sql server, Postgres ten gelmiş gibi simule ediyoruz.
                new Product {ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, unitsInStock=15},
                new Product {ProductId=2, CategoryId=2, ProductName="Kamera", UnitPrice=500, unitsInStock=3},
                new Product {ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, unitsInStock=2},
                new Product {ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, unitsInStock=65},
                new Product {ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, unitsInStock=1},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product); //Listeye ekleme yapıcaz.
        }

        public void Delete(Product product)
        {
            // _products.Remove(product); -- normalde bu şekilde yapınca listeden eleman silinir ama burda neden işe yaramaz. Referans tipleriyle alakalı bir şey. O referansa ait kısmı bulamaz bu yüzdende silemez.
            //Her ürünün product Id si farklıdır. Bu yüzden ıd kullanılır.

            //Product productToDelete=null; //linq ifadesini bilmiyoruz varsayalım. Her ürünü bir döngüyle dolaşmak gerekir.
            //foreach (var P in _products)
            //{
            //    if (product.ProductId == P.ProductId)
            //    {
            //        productToDelete = P;
            //    }
            //}
            //_products.Remove(productToDelete); //Bu şekilde kod sonlanırdı.

            //LINQ - Language Integrted Query - Dile gömülü sorgulama
            //p=> lambda denir

            Product productToDelete = _products.SingleOrDefault(p=>p.ProductId == product.ProductId); //eşitliğin sağındaki foreach kısmını yapıyor.
            _products.Remove(productToDelete);

            //SingleOrDefault yerine FirstOrDefault yada first de kullanılabilir.
        }

        public List<Product> GetAll()
        {
            return _products; //Burada listeyi döndürmemiz gerekir.
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=> p.CategoryId == categoryId).ToList(); //Listlerde return'u unutma.
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul.
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;       //Bu şekilde herbirini güncelleyebiliriz.
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.unitsInStock = product.unitsInStock;
        }
    }
}
//Bu yapılanları bizim için yapan uygulamalar vardır. Bu mantığını kavramak iindir.
