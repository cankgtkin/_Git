using System.Web.Http;
using System.Web.Mvc;
using ZeyrekFramework.Business.DependencyResolvers.Ninject;
using ZeyrekFramework.Core.Utilities.BotFramework.Infrastructure;

namespace ZeyrekFramework.Bot
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);
            ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory(new BusinessModule(),new AutoMapperModule()));
        } 
    }
}
