﻿using Nop.Core.Domain.Common;
using Nop.Services.Caching;

namespace Nop.Services.Common.CacheEventConsumers
{
    /// <summary>
    /// Represents a address attribute cache event consumer
    /// </summary>
    public partial class AddressAttributeCacheEventConsumer : CacheEventConsumer<AddressAttribute>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(AddressAttribute entity)
        {
            Remove(NopCommonDefaults.AddressAttributesAllCacheKey);

            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopCommonDefaults.AddressAttributeValuesAllCacheKey, entity);
            Remove(cacheKey);
        }
    }
}