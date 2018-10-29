using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    public interface IIntentService
    {
      Task<Intent> GetIntent(string intentName,string applicationId);
    }
}
