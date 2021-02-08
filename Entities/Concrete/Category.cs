using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
//2.
namespace Entities.Concrete
{
    //Çıplak class kalmasın. Yani interface ekle. Bu kontrol etmeyi sağlar.
    //İşaretleme yaparız.
    public class Category:IEntity //okunmicaktır bu yüzden ampulden using de
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
