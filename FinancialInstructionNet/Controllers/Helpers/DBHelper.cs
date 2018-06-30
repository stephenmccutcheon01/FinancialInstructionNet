using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Web;

namespace FinancialInstructionNet.Controllers.Helpers
{
    public class DBHelper
    {
        /// <summary>
        ///     Get the Data From the Cache
        /// </summary>
        /// <typeparam name="TEntity"></typeparam>
        /// <param name="key"></param>
        /// <returns></returns>
        /// <remarks>
        ///     Date:   28/06/2018
        ///     Author: Stephen McCutcheon
        /// </remarks>
        public  static TEntity GetFromCache<TEntity>(string key) where TEntity : class //Func<TEntity> valueFactory) where TEntity : class
        {
            ObjectCache cache = MemoryCache.Default;
            // the lazy class provides lazy initializtion which will eavaluate the valueFactory expression only if the item does not exist in cache
            var newValue = new Lazy<TEntity>();//(valueFactory);
            CacheItemPolicy policy = new CacheItemPolicy { AbsoluteExpiration = DateTimeOffset.Now.AddMinutes(30) };
            //The line below returns existing item or adds the new value if it doesn't exist
            var value = cache.AddOrGetExisting(key, newValue, policy) as Lazy<TEntity>;// newValue, policy) as Lazy<TEntity>;
            return (value ?? newValue).Value; // Lazy<T> handles the locking itself
        }
    }
}