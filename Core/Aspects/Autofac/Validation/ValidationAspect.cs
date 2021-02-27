using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("Bu bir dogrulama sınıf deil");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            var validator = (IValidator)Activator.CreateInstance(_validatorType);//burası bir reflection dır. bu carvalidator'ın bir instance ı olsutur
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];//calisma tipinin base typeını bul sonra onunn linkini bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);//ilgili methodun parametrelerini bul(invocatiion= method)
            foreach (var entity in entities)
            {
                ValidationTool.Validate(validator, entity);
            }
        }
    }
}
