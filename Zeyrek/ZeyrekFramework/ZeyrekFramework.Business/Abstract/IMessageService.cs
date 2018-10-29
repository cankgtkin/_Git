using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    public interface IMessageService
    {
      Task<string> SetMessage(Message data);
      Task<string> UpdateMessage(Message data);
    }
}
