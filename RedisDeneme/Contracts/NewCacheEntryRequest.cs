using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RedisDeneme.Contracts
{
    public class NewCacheEntryRequest
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
}
