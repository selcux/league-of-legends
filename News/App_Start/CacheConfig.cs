using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web.Mvc;
using News.Models;
using News.Repositories;
using News.Services.CacheService;

namespace News {
    public static class CacheConfig {
        private static Timer _timer;

        private static INewsRepository NewsRepository =>
            DependencyResolver.Current.GetService<INewsRepository>();

        private static INewsCacheService NewsCacheService =>
            DependencyResolver.Current.GetService<INewsCacheService>();

        public static void CacheAllDataAtStart() {
            CacheAllData();

            if (_timer == null) {
                _timer = new Timer(StaticValues.Cache.TimerInterval);

                _timer.Elapsed += TimerOnUpdate;
                _timer.Start();
            }
        }

        private static void CacheAllData() {
            var news = NewsRepository.Get().ToList();
            NewsCacheService.Cache = news;
        }

        private static void TimerOnUpdate(object sender,
            ElapsedEventArgs elapsedEventArgs) {
            if (NewsCacheService.Cache == null) {
                CacheAllData();

                return;
            }

            var updatedNews = NewsRepository.Get()
                .Where(x =>
                    x.LastUpdatedTime.HasValue &&
                    NewsCacheService.Cache.Any(c => c.LastUpdatedTime != x.LastUpdatedTime));

            foreach (var news in updatedNews) {
                var model = NewsCacheService.Cache.SingleOrDefault(x => x.Id == news.Id);
                NewsCacheService.Cache.Remove(model);
                NewsCacheService.Cache.Add(news);
            }

            var latestNews = NewsRepository.Get()
                .Where(x =>
                    !x.LastUpdatedTime.HasValue && NewsCacheService.Cache.All(c => c.Id != x.Id));

            NewsCacheService.Cache.AddRange(latestNews);
        }
    }
}