using Ninject;

namespace DevFramework.Northwind.Business.DependencyResolvers.Ninject
{
    public class InstanceFactory
    {
        public static T GetInstance<T>()
        {
            var kernal = new StandardKernel(new BusinessModule());
            return kernal.Get<T>();
        }
    }
}
