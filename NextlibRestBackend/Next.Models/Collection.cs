using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Next.Models
{
    public interface ICollection
    {
        [BsonId]
        ObjectId Id { get; set; }
    }
}
