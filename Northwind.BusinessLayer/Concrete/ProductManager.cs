using System;
using System.Collections.Generic;
using Northwind.BusinessLayer.Abstract;
using Northwind.EntitiesLayer.Concrete;
using Northwind.DataAccessLayer.Abstract;
using Northwind.Core.Utilies.Results;
using Northwind.BusinessLayer.Constants;
using Northwind.BusinessLayer.ValidationRules.FluentValidation;
using Northwind.Core.Aspects.Autofac;
namespace Northwind.BusinessLayer.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        [ValidationAspect(typeof(ProductValidator),Priority=1)]
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));

        }

        public IDataResult<List<Product>> GetList()
        {             
            return new SuccessDataResult<List<Product>>(_productDal.GetList());
        }

        public IDataResult<List<Product>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(x => x.CategoryId == categoryId));
        }

        [TransactionScopeAspect]
        public IResult TransactionalOperation(Product product)
        {
            _productDal.Add(product);
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}