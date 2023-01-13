using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace Afy.Library.WebUI.Models
{
    public class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? Id { get; set; }
    }
}
