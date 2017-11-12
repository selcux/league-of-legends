using System.Data.Entity;
using News.Models;

namespace News.Repositories {
    public class NewsDbContext : DbContext, INewsDbContext {
        public DbSet<NewsModel> News { get; set; }
    }
}