using System;
using StackExchange.Redis;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Newtonsoft.Json;

namespace hobby.Data.Redis
{
    public class RedisManager : ICache
    {
        public ConnectionMultiplexer connectionMultiplexer;
        string connction = "";
        int Default_Timeout = 600;//默认超时时间（单位秒）
        JsonSerializerSettings jsonConfig = new JsonSerializerSettings() { ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore, NullValueHandling = NullValueHandling.Ignore };
        IDatabase database;
        public RedisManager()
        {
            this.connction = ConfigurationManager.AppSettings["RedisCon"];
            if (connction != null)
            {
               connectionMultiplexer= ConnectionMultiplexer.Connect(this.connction);
                database = connectionMultiplexer.GetDatabase();
            }        }

        class CacheObject<T>
        {
            public int ExpireTime { get; set; }
            public bool ForceOutofDate { get; set; }
            public T Value { get; set; }
        }
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
            throw new NotImplementedException();
        }

        public T Get<T>()
        {
            throw new NotImplementedException();
        }

        public void Insert(string key, object data)
        {
            throw new NotImplementedException();
        }

        public void Insert<T>(string key, T data)
        {
            throw new NotImplementedException();
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
