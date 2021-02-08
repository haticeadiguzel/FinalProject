using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
//1.
namespace Entities.Concrete
{
    public class Product:IEntity //public bu class'a diğer katmanlarda ulaşsın demek
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short unitsInStock { get; set; } //int'in bir küçüğü. Veri tabanına uymak için böyle yazıldı.
        public decimal UnitPrice { get; set; } //decimalde para birimi tutulur
    }
}
