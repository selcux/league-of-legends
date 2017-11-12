using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using News.Models;

namespace News.Repositories {
    public class NewsRepository : INewsRepository {
        private readonly INewsDbContext _dbContext;

        public NewsRepository(INewsDbContext dbContext) {
            _dbContext = dbContext;
        }

        public IEnumerable<NewsModel> Get() =>
            _dbContext.News;

        public async Task<NewsModel> Get(int id) =>
            await _dbContext.News.FindAsync(id);

        public async Task Add(NewsModel model) {
            _dbContext.News.Add(model);

            await _dbContext.SaveChangesAsync();
        }

        public async Task Update(NewsModel model) {
            _dbContext.Entry(model).State = EntityState.Modified;

            await _dbContext.SaveChangesAsync();
        }

        public async Task Remove(int id) {
            var model = await Get(id);

            if (model != null) {
                _dbContext.News.Remove(model);

                await _dbContext.SaveChangesAsync();
            }
        }
    }
}