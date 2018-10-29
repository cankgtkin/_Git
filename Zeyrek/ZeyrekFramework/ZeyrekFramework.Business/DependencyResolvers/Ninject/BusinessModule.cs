using Ninject.Modules;
using ZeyrekFramework.Business.Abstract;
using ZeyrekFramework.Business.Concrete.Managers;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.DataAccess.Concrete.ConnectivityApi;

namespace ZeyrekFramework.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IApplicationService>().To<ApplicationManager>().InSingletonScope();
            Bind<IApplicationDal>().To<DbApplicationDal>().InSingletonScope(); 
        }
    }
}
