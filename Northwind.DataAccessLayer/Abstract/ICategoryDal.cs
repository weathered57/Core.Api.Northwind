using Northwind.EntitiesLayer.Concrete;
using Northwind.Core.DataAccess;
namespace Northwind.DataAccessLayer.Abstract
{
    public interface ICategoryDal:IEntityRepository<Category>
    {
    }
}