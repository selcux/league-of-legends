using System.Collections.Generic;
using System.Web;
using News.Models;

namespace News.Services.CacheService {
    public class NewsCacheService : INewsCacheService {
        public List<NewsModel> Cache {
            get => HttpRuntime.Cache[StaticValues.Cache.News] as List<NewsModel>;
            set => HttpRuntime.Cache[StaticValues.Cache.News] = value;
        }
    }
}