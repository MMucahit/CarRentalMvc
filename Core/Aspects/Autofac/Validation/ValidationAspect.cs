using Castle.DynamicProxy;
using Core.CrossCuttingConcern.Validation;
using Core.Utilities.Interceptors;
using FluentValidation;

namespace Core.Aspects.Autofac.Validation
{
    public class ValidationAspect : MethodInterception
    {
        private Type _validatorType;
        public ValidationAspect(Type validatorType)
        {
            if (!typeof(IValidator).IsAssignableFrom(validatorType))
            {
                throw new System.Exception("This isn't a validation class!");
            }

            _validatorType = validatorType;
        }
        protected override void OnBefore(IInvocation invocation)
        {
            // Reflaction : Çalışma anında bir şeyleri yapmaya yarar.
            //Çalışma anında valitator newle
            var validator = (IValidator)Activator.CreateInstance(_validatorType);
            // Newlenen validatorun base sınıfına git yani ProductValidator mesela Generic parametrelerin 1.sini al
            var entityType = _validatorType.BaseType.GetGenericArguments()[0];
            // Invocation sarmalladığımız methodun kendisi
            // Anotation yazdığımız methodun bir üst satırda bulduğumuz tipdeki parametrelerini bul
            var entities = invocation.Arguments.Where(t => t.GetType() == entityType);
            foreach (var entity in entities)
            {
                // Yukarıda bulduğumuz parameteler ile yazdığımız validationtool u çalıştır.
                ValidationTools.Validate(validator, entity);
            }
        }
    }
}
