using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    //T yerine yazılan şeyi sadece entity concrete kısmı ile sınırlamak isteriz. Çünkü T yerine ne yazılırsa kabul edilir.
    //Buna generic consraint denir. kısıtlama
    //Class demek referans tip olabilir demektir.
    //IEntity olabilir yada implemente edilmiş olabir.
    //new() new'lenebilir olmalı bu sayede IEntity kullanamayız

    public interface IEntityRepository<T> where T:class,IEntity,new()  //Generics i burda kullanıyoruz.SAdece class olabilir diye sınırlandırıyoruz.
    {
        
        List<T> GetAll(Expression<Func<T, bool>> filter = null); //Filtreleme için
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        //List<T> GetAllByCategory(int categoryId); //Bu ürünleri kategoriye göre filtrele demektir.
        //Yukarıda yazılan Expression kısmı sayesinde böyle kodlara gerek kalmicak. Kodlar içinde artık istenildiği kadar filtreleme yapılabilir.
    }
}
