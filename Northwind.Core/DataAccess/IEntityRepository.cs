using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Northwind.EntitiesLayer.Absract;
namespace Northwind.Core.DataAccess
{
    public interface IEntityRepository<T>  where T: class,IEntity,new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter = null);
        T Add(T entity);
        T Update(T entity);
        void Delete(T entity);
    }
}