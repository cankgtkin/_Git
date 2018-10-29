using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    public interface IApplicationService
    {
      Task<Application> GetApplication(string applicationName);
    }
}
