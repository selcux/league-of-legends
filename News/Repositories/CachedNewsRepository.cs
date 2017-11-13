using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using News.Models;
using News.Services.CacheService;

namespace News.Repositories {
    public class CachedNewsRepository : NewsRepository, ICachedNewsRepository {
        protected readonly INewsCacheService CacheService;

        public CachedNewsRepository(INewsDbContext dbContext, INewsCacheService cacheService) : base(dbContext) {
            CacheService = cacheService;
        }

        public override IEnumerable<NewsModel> Get() => CacheService.Cache;

        public override async Task<NewsModel> Get(int id) {
            var model = CacheService.Cache.SingleOrDefault(x => x.Id == id);

            if (model == null) {
                model = await base.Get(id);

                if (model != null) {
                    CacheService.Cache.Add(model);
                }
            }

            return model;
        }

        public override async Task Remove(int id) {
            var model = CacheService.Cache.SingleOrDefault(x => x.Id == id);

            if (model != null) {
                CacheService.Cache.Remove(model);
            }

            await base.Remove(id);
        }
    }
}