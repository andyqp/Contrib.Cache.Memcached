using Contrib.Cache.Memcached.Models;
using Orchard.ContentManagement.Handlers;

namespace Contrib.Cache.Memcached.Handlers {
    public class MemcachedSettingsPartHandler : ContentHandler {

        public MemcachedSettingsPartHandler() {
            Filters.Add(new ActivatingFilter<MemcachedSettingsPart>("Site"));
        }
    }
}