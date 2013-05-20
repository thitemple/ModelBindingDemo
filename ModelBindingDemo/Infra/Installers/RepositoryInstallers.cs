using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using MvcApplicationCustomModelBinder.Models;

namespace MvcApplicationCustomModelBinder.Infra.Installers
{
    public class RepositoryInstallers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(
                Component.For<QuestionsContext>()
                    .LifestylePerWebRequest());

            //container.Register(
            //    Component.For<IDependencia>()
            //    .ImplementedBy<Dependencia>()
            //    .LifestyleTransient(),
            //    Component.For<ITarefaRepository>()
            //    .ImplementedBy<TarefaEntityFrameworkRepository>()
            //    .LifestyleTransient());

        }
    }
}