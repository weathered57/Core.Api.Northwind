using Northwind.Core.Utilies.Results;
using Northwind.EntitiesLayer.Concrete;
using System.Collections.Generic;
namespace Northwind.BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        IDataResult<List<Category>> GetList();
    }
}