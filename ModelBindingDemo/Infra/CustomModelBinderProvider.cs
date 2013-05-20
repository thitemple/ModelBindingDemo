using System;
using System.Web.Mvc;
using Castle.MicroKernel;
using MvcApplicationCustomModelBinder.Models;

namespace MvcApplicationCustomModelBinder.Infra
{
    public class CustomModelBinderProvider : IModelBinderProvider
    {
        private readonly IKernel _kernel;

        public CustomModelBinderProvider(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IModelBinder GetBinder(Type modelType)
        {
            if (!typeof(Entity).IsAssignableFrom(modelType))
                return null;

            Type modelBinderType = typeof (CustomModelBinder<>)
                .MakeGenericType(modelType);


            return _kernel.Resolve(modelBinderType) as IModelBinder;
        }
    }
}