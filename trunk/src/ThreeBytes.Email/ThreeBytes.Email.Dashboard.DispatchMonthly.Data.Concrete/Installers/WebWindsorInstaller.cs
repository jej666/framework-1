using Castle.Core;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using ThreeBytes.Core.Bootstrapper.Extensions.Windsor.Installers;
using ThreeBytes.Email.Dashboard.DispatchMonthly.Data.Abstract;
using ThreeBytes.Email.Dashboard.DispatchMonthly.Data.Abstract.Infrastructure;

namespace ThreeBytes.Email.Dashboard.DispatchMonthly.Data.Concrete.Installers
{
    public class WebWindsorInstaller : IWebWindsorRegistration
    {
        public void Install(IWindsorContainer container)
        {
            container.Register(
                AllTypes.FromThisAssembly().BasedOn<IDispatchMonthlyDashboardDatabaseFactory>().Configure(
                    component =>
                    {
                        component.Named(component.Implementation.Name);
                        component.LifeStyle.Is(LifestyleType.PerWebRequest);
                    }).WithService.Base(),
                AllTypes.FromThisAssembly().BasedOn<IDispatchMonthlyDashboardUnitOfWork>().Configure(
                    component =>
                    {
                        component.Named(component.Implementation.Name);
                        component.LifeStyle.Is(LifestyleType.PerWebRequest);
                    }).WithService.Base(),
                AllTypes.FromThisAssembly().BasedOn<IProvideDispatchMonthlyDashboardSessionFactoryInitialisation>().Configure(
                    component =>
                    {
                        component.Named(component.Implementation.Name);
                        component.LifeStyle.Is(LifestyleType.PerWebRequest);
                    }).WithService.Base(),
                AllTypes.FromThisAssembly().BasedOn<IDispatchMonthlyDashboardRepository>().Configure(
                    component =>
                    {
                        component.Named(component.Implementation.Name);
                        component.LifeStyle.Is(LifestyleType.PerWebRequest);
                    }).WithService.Base()
            );
        }
    }
}