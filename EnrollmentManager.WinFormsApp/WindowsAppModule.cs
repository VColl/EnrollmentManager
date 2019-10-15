using EnrollmentManager.InterfaceBusiness;
using EnrollmentManager.InterfaceBusiness.Boundary;
using Ninject.Modules;

namespace EnrollmentManager.WinFormsApp
{
    internal class WindowsAppModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IConfiguration>().To<Configuration>();
            Bind<INotifier>().To<Notifier>();
            Bind<IExceptionHandler>().To<ExceptionHandler>();
        }
    }
}
