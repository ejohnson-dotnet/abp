using System.Collections.Generic;
using System.Threading.Tasks;
using Volo.Abp.Caching;
using Volo.Abp.DependencyInjection;
using Volo.CmsKit.Pages;
using Volo.CmsKit.Public.Pages;

namespace Volo.CmsKit.Public.Web.Pages;

public class CmsKitRemotePageStore : ITransientDependency
{
    protected IDistributedCache<CmsKitPageSlugCacheItem> Cache { get; }

    protected IPagePublicAppService PagePublicAppService { get; }

    public CmsKitRemotePageStore(
        IDistributedCache<CmsKitPageSlugCacheItem> cache,
        IPagePublicAppService pagePublicAppService)
    {
        Cache = cache;
        PagePublicAppService = pagePublicAppService;
    }

    public virtual async Task<bool> DoesSlugExistAsync(string slug)
    {
        var cacheItem = await Cache.GetAsync(CmsKitPublicPagesCache.CacheKey);

        if (cacheItem == null)
        {
            cacheItem = new CmsKitPageSlugCacheItem();
            cacheItem.Items[slug] = await PagePublicAppService.DoesSlugExistAsync(slug);
            await Cache.SetAsync(CmsKitPublicPagesCache.CacheKey, cacheItem);
        }

        if (cacheItem.Items.TryGetValue(slug, out var exist))
        {
            return exist;
        }

        return false;
    }
}

public class CmsKitPageSlugCacheItem
{
    public Dictionary<string, bool> Items { get; set; } = new();
}