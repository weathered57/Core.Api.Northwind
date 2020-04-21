using System;
using System.Reflection;
using Castle.DynamicProxy;
using System.Collections.Generic;
using Northwind.Core.Utilies.Interceptors;
using System.Linq;
namespace Northwind.Core.Utilies.Interceptors
{
    public class AspectInterceptorSelector : IInterceptorSelector
    {
        public IInterceptor[] SelectInterceptors(Type type, MethodInfo method, IInterceptor[] interceptors)
        {
            var classAttributes=type.GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
            var methodAttribute=type.GetMethod(method.Name).GetCustomAttributes<MethodInterceptionBaseAttribute>(true);
        classAttributes.ToList().AddRange(methodAttribute);

        return classAttributes.OrderBy(x=>x.Priotity).ToArray();
        }
    }
}