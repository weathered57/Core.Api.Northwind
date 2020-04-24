using Northwind.Core.DataAccess.EntitiyFramework;
using Northwind.EntitiesLayer.Concrete;
using Northwind.DataAccessLayer.Abstract;
using Northwind.DataAccessLayer.Concrete.EntitityFramework.Context;
namespace Northwind.DataAccessLayer.Concrete.EntitityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
    } 
}