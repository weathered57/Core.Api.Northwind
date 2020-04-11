using Northwind.Core.DataAccess;
using Northwind.EntitiesLayer.Concrete;
namespace Northwind.DataAccessLayer.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}