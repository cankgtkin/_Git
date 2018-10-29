using System;
using StackExchange.Redis;
using System.Configuration;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace ZeyrekFramework.Core.CrossCuttingConcerns.Caching.Microsoft
{
    public class MemoryCacheManager : ICacheManager
    {
        public static Lazy<ConnectionMultiplexer> LazyConnection { get; } = new Lazy<ConnectionMultiplexer>(() =>
        {
            string cacheConnection = ConfigurationManager.AppSettings["CacheConnection"].ToString();
            return ConnectionMultiplexer.Connect(cacheConnection);
        });

        public static ConnectionMultiplexer Connection
        {
            get
            {
                return LazyConnection.Value;
            }
        }
        IDatabase _cache = LazyConnection.Value.GetDatabase();

        public T Get<T>()
        {
            return (T) _cache;
        }
        public void Add(string key, object data, int cacheTime = 60)
        {
            if (data == null)
            {
                return; 
            }
          
            _cache.StringSet(key, JsonConvert.SerializeObject(data), TimeSpan.FromMinutes(cacheTime));  
        }

        public bool IsAdd(string key)
        {
            return _cache.KeyExists(key);
        }
        public void RemoveByPattern(string pattern)
        {
            var regex = new Regex(pattern, RegexOptions.Singleline | RegexOptions.Compiled | RegexOptions.IgnoreCase);
            _cache.KeyDelete(regex.ToString());
        }
        public void Remove(string key)
        {
            _cache.KeyDelete(key);
        }
        
       
    }
}
