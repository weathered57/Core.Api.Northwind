using System;
using Northwind.Core.DataAccess.EntitiyFramework;
using Northwind.EntitiesLayer.Concrete;
using Northwind.DataAccessLayer.Abstract;
namespace Northwind.DataAccessLayer.Concrete.EntitityFramework.Context
{
   public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
       
    }
}