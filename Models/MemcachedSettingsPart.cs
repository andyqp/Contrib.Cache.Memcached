using Orchard.ContentManagement;

namespace Contrib.Cache.Memcached.Models {
    public class MemcachedSettingsPart : ContentPart {
        public const string CacheKey = "MemcachedSettingsPart";

        public string Servers {
            get { return this.Retrieve(x => x.Servers); }
            set { this.Store(x => x.Servers, value); }
        }
    }
}