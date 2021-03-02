using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
//1.
namespace Entities.Concrete
{
    public class Product:IEntity
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short unitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
