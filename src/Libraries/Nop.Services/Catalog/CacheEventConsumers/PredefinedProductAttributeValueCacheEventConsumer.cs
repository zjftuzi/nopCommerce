﻿using Nop.Core.Domain.Catalog;
using Nop.Services.Caching;

namespace Nop.Services.Catalog.CacheEventConsumers
{
    /// <summary>
    /// Represents a predefined product attribute value cache event consumer
    /// </summary>
    public partial class PredefinedProductAttributeValueCacheEventConsumer : CacheEventConsumer<PredefinedProductAttributeValue>
    {
        /// <summary>
        /// Clear cache data
        /// </summary>
        /// <param name="entity">Entity</param>
        protected override void ClearCache(PredefinedProductAttributeValue entity)
        {
            var cacheKey = _cacheKeyService.PrepareKeyForDefaultCache(NopCatalogDefaults.PredefinedProductAttributeValuesAllCacheKey, entity.ProductAttributeId);
            Remove(cacheKey);
        }
    }
}