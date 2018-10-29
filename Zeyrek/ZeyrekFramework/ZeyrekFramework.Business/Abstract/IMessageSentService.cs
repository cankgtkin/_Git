using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    public interface IMessageSentService
    {
      Task<MessageSent> GetMessageSent(string referanceId,int type);
    }
}
