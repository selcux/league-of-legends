using System.Collections.Generic;
using System.Threading.Tasks;
using News.Models;

namespace News.Repositories {
    public interface INewsRepository {
        IEnumerable<NewsModel> Get();
        Task<NewsModel> Get(int id);
        Task Add(NewsModel model);
        Task Update(NewsModel model);
        Task Remove(int id);
    }
}