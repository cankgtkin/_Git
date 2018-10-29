using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    public interface ISessionService
    {
      Task<string> SetSession(Session data);
      Task<string> UpdateSession(Session data);
    }
}
