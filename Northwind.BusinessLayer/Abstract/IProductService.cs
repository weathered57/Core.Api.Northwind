using System;
using System.Collections.Generic;
using Northwind.EntitiesLayer.Concrete;
using Northwind.Core.Utilies.Results;
namespace Northwind.BusinessLayer.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetListByCategory(int categoryId);
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(Product product);
        IResult TransactionalOperation(Product product);
    }
}