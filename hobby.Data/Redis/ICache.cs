using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hobby.Data.Redis
{
   public interface ICache
    {
        /// <summary>
        /// 缓存时间
        /// </summary>
        int TimeOut { get; set; }

        /// <summary>
        /// 获取指定键的缓存值
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        object Get(string key);

        /// <summary>
        /// 获取指定键缓存值
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        T Get<T>(string key);

        /// <summary>
        ///从缓存中移除指定的键值
        /// </summary>
        /// <param name="key"></param>
        void Remove(string key);

        /// <summary>
        ///清除所有缓存对象
        /// </summary>
        void Clear();
        /// <summary>
        /// 将指定键对象插入到缓存当中
        /// </summary>
        /// <param name="key"></param>
        /// <param name="data"></param>
        void Insert(string key, object data);

        /// <summary>
        ///将指定键的对象添加到缓存当中
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="key"></param>
        /// <param name="data"></param>
        void Insert<T>(string key, T data);
        /// <summary>
        /// 将指定键的对象添加到缓存当中,并设置过期时间
        /// </summary>
        /// <param name="key">键名</param>
        /// <param name="data">数据对象</param>
        /// <param name="cacheTime">有效时间</param>
        void Insert(string key, object data, int cacheTime);

        /// <summary>
        /// 根据key 是否存在
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        bool Exists(string key);
    }
}
