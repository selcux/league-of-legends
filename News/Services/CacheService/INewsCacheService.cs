using System.Collections.Generic;
using News.Models;

namespace News.Services.CacheService {
    public interface INewsCacheService {
        List<NewsModel> Cache { get; set; }
    }
}