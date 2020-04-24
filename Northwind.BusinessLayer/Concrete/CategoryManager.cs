using Northwind.DataAccessLayer.Abstract;
using Northwind.Core.Utilies.Results;
using Northwind.EntitiesLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
namespace Northwind.BusinessLayer.Concrete
{
    public class CategoryManager
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IDataResult<List<Category>> GetList()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetList().ToList());
        }
    }
}