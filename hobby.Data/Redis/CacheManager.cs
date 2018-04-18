using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace hobby.Data.Redis
{
    public class CacheManager : ICache
    {
        int Default_Timeout = 600;//默认超时时间（单位秒）
        public int TimeOut {
            get
            {
                return Default_Timeout;
            }
            set
            {
                Default_Timeout = value;
            }
        }

        public void Clear()
        {
            throw new NotImplementedException();
        }

        public bool Exists(string key)
        {
            throw new NotImplementedException();
        }

        public object Get(string key)
        {
          return  HttpRuntime.Cache.Get(key);
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void Insert(string key, object data)
        {
            HttpRuntime.Cache.Insert(key, data); ;
        }

        public void Insert<T>(string key, T data)
        {
            HttpRuntime.Cache.Insert(key,data);
        }

        public void Insert(string key, object data, int cacheTime)
        {
            throw new NotImplementedException();
        }

        public void Remove(string key)
        {
            throw new NotImplementedException();
        }
    }
}
