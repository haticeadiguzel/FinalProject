using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstact
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetAll();
        IDataResult<Order> Get(int orderId);
        IResult Add(Order order);
        IResult Delete(Order order);
        IResult Update(Order order);
    }
}
