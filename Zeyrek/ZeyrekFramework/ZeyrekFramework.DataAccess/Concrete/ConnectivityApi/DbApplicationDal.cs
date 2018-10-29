﻿using System.Net.Http;
using ZeyrekFramework.Core.DataAccess.ConnectivityApi;
using ZeyrekFramework.DataAccess.Abstract;
using ZeyrekFramework.Entities.Concrete;

namespace ZeyrekFramework.DataAccess.Concrete.ConnectivityApi
{
    public class DbApplicationDal : DbEntityRepositoryBase<Application, HttpClient>, IApplicationDal
    {
     
    }
}
