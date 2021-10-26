﻿
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        public List<Product> GetByUnitPrice(decimal min, decimal max);
        List<Product> GetAllByCategoryId(int id);
    }
}
