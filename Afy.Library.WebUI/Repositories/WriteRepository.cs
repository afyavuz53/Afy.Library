using Afy.Library.WebUI.Interfaces.Repositories;
using Afy.Library.WebUI.Models;
using Afy.Library.WebUI.Models.Options;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Afy.Library.WebUI.Repositories
{
    internal class WriteRepository<T> : MongoRepository<T>, IWriteRepository<T>
        where T : BaseEntity
    {
        public WriteRepository(IOptions<AppConfig> appconfig) : base(appconfig)
        {
        }
        public async Task CreateAsync(T newProduct) =>
            await _collection.InsertOneAsync(newProduct);

        public async Task UpdateAsync(string id, T updatedProduct) =>
            await _collection.ReplaceOneAsync(x => x.Id == id, updatedProduct);

        public async Task RemoveAsync(string id) =>
            await _collection.DeleteOneAsync(x => x.Id == id);
    }
}
