﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
//4.
namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        
    }
}
