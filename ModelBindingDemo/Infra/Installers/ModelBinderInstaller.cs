using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MvcApplicationCustomModelBinder.Models;

namespace MvcApplicationCustomModelBinder.Infra.Installers
{
    public class ModelBinderInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For(typeof(CustomModelBinder<>)).LifestyleTransient());
        }
    }
}