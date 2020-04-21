using Northwind.Core.Utilies.Interceptors;
using Castle.DynamicProxy;
using FluentValidation;
using System;
using Northwind.Core.Utilies.Messages;
using System.Linq;
using Northwind.Core.CrossCuttingCorcerns.Validation;
namespace Northwind.Core.Aspects.Autofac
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if(!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new Exception(AspectMessages.WrongValidation);
            }
            _validatorType=validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator=(IValidator)Activator.CreateInstance(_validatorType);
            var entityType=_validatorType.BaseType.GetGenericArguments()[0];
            var entities=invocation.Arguments.Where(t=>t.GetType() == entityType);
           
            foreach (var entity in entities)
            {
                ValidationTools.Validate(validator,entity);
            }
        }
    }
}