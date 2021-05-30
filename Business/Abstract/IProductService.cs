using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GertAll();

        List<Product> GetAllByCategoryId(int Id);

        List<Product> GetByUnitPrice(decimal min, decimal max);

    }
}
