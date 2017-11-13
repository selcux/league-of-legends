using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using News.Models;

namespace News.Repositories {
    public class NewsRepository : INewsRepository {
        protected readonly INewsDbContext DbContext;

        public NewsRepository(INewsDbContext dbContext) {
            DbContext = dbContext;
        }

        public virtual IEnumerable<NewsModel> Get() =>
            DbContext.News;

        public virtual async Task<NewsModel> Get(int id) =>
            await DbContext.News.FindAsync(id);

        public virtual async Task Add(NewsModel model) {
            DbContext.News.Add(model);

            await DbContext.SaveChangesAsync();
        }

        public virtual async Task Update(NewsModel model) {
            DbContext.Entry(model).State = EntityState.Modified;

            await DbContext.SaveChangesAsync();
        }

        public virtual async Task Remove(int id) {
            var model = await Get(id);

            if (model != null) {
                DbContext.News.Remove(model);

                await DbContext.SaveChangesAsync();
            }
        }
    }
}