using Afy.Library.WebUI.Interfaces.Repositories;
using Afy.Library.WebUI.Models;
using Afy.Library.WebUI.Models.Options;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System.Linq.Expressions;

namespace Afy.Library.WebUI.Repositories
{
    internal class ReadRepository<T> : MongoRepository<T>, IReadRepository<T>
        where T : BaseEntity
    {
        public ReadRepository(IOptions<AppConfig> appconfig) : base(appconfig)
        {
        }

        public async Task<IEnumerable<T>> GetAsync() =>
        await _collection.Find(_ => true).ToListAsync();
        public async Task<IEnumerable<T>> GetAsync(Expression<Func<T, bool>> filter) =>
        await _collection.Find(filter).ToListAsync();

        public async Task<T?> GetAsync(string id) =>
            await _collection.Find(x => x.Id == id).FirstOrDefaultAsync();
    }
}
