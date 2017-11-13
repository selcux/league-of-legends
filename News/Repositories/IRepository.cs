using System.Collections.Generic;
using System.Threading.Tasks;
using News.Models;

namespace News.Repositories {
    public interface IRepository<TModel> : IBaseRepository where TModel : BaseModel {
        IEnumerable<TModel> Get();
        Task<TModel> Get(int id);
        Task Add(TModel model);
        Task Update(TModel model);
        Task Remove(int id);
    }
}