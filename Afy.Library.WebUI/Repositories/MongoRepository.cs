using Afy.Library.WebUI.Models;
using Afy.Library.WebUI.Models.Options;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Afy.Library.WebUI.Repositories
{
    internal abstract class MongoRepository<T>
        where T : BaseEntity
    {
        internal readonly IMongoCollection<T> _collection;
        public MongoRepository(IOptions<AppConfig> appconfig)
        {
            var mongoClient = new MongoClient(
            appconfig.Value.ConnectionString);

            var mongoDatabase = mongoClient.GetDatabase(
                appconfig.Value.DatabaseName);

            _collection = mongoDatabase.GetCollection<T>(typeof(T).Name + "s");
        }
    }
}
