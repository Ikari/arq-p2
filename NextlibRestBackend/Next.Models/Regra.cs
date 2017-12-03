using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Next.Models
{
    public class Regra : ICollection
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string OuterId { get { return Id.ToString(); } }
        [BsonElement("regra")]
        public string Nome { get; set; }
    }
}
