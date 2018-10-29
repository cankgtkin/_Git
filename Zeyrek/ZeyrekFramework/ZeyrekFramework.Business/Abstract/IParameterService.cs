using System.Collections.Generic;
using System.Threading.Tasks;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.Business.Abstract
{
    public interface IParameterService
    {
      Task<List<Parameter>> GetParameterList(string intentId);
      Task<Parameter> GetParameter(string intentId,string parameterName);
    }
}
