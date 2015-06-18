using System.Collections.Generic;
using Orchard.Environment.Extensions;
using Orchard.OutputCache.Services;
using CacheItem = Orchard.OutputCache.Models.CacheItem;

namespace Contrib.Cache.Memcached.Services {
    [OrchardSuppressDependency("Orchard.OutputCache.Services.DefaultCacheStorageProvider")]
    public class MemcachedOutputCacheStorageProvider : IOutputCacheStorageProvider {
        private readonly IMemcachedClientHolder _clientHolder;

        public MemcachedOutputCacheStorageProvider(IMemcachedClientHolder clientHolder) {
            _clientHolder = clientHolder;
        }

        public void Set(string key, CacheItem cacheItem) {
            _clientHolder.Set(key, cacheItem);
        }

        public void Remove(string key) {
            _clientHolder.Remove(key);
        }

        public void RemoveAll() {
            _clientHolder.RemoveAll();
        }

        public CacheItem GetCacheItem(string key) {
            return _clientHolder.GetCacheItem(key);
        }

        public IEnumerable<CacheItem> GetCacheItems(int skip, int count) {
            return _clientHolder.GetCacheItems(skip, count);
        }

        public int GetCacheItemsCount() {
            return _clientHolder.GetCacheItemsCount();
        }
    }
}