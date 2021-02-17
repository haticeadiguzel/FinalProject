using Business.Abstact;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
//7.
namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal) //Bunu ampulden Generete instrocter diyeek çağırdık
        {
            _productDal = productDal;
        }

        public IResult Add(Product product)
        {
            //business codes

            if (product.ProductName.Length<2)
            {
                //magic strings
                return new ErrorResult(Messages.ProductNameInvalid);
            }

            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IDataResult<List<Product>> GetAll()
        {
            //İş kodları
            //Bir iş sınıfı başka sınıfları newk-lemez. Bu yüzden metotların dışında bir global kurarız.
            if (DateTime.Now.Hour==22)
            {
                return new ErrorDataResult();
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(),true,"Ürünler listelendi"); //yukarıcaki construvctor sayesinde return edebildik.
            //Business da sadece IProductDal dır.
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.GetAll(p=>p.CategoryId==id); //önceden yazdığımız filtreleme kodu sayesinde bunların hepsini yazabiliyoruz
        }

        public Product GetById(int productId)
        {
            return _productDal.Get(p=>p.ProductId==productId);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            return _productDal.GetProductDetails();

        }
    }
}
