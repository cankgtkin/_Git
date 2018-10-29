using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    public interface IErrorService
    {
      Task<string> SetError(Error data);
    }
}
