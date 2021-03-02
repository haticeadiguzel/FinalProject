using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
//6.
namespace Business.Abstact
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> Get(int productId);
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
    }
}
