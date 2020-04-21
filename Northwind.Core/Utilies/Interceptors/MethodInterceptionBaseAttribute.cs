using System;
using Castle.DynamicProxy;
namespace Northwind.Core.Utilies.Interceptors
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method ,AllowMultiple=true,Inherited=true)]
    public abstract class MethodInterceptionBaseAttribute : Attribute,IInterceptor
    {
        public int Priotity { get; set; }

        public virtual void Intercept(IInvocation invocation)
        {
            
        }
    }
}