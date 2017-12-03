using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Next.Models
{
    public class Cliente : ICollection
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string OuterId { get { return Id.ToString(); } }
        [BsonElement("nome")]
        public string Nome { get; set; }
        [BsonElement("cpf")]
        public string Cpf { get; set; }
        [BsonElement("nascimento")]
        public string Nascimento { get; set; }
        [BsonElement("telefone")]
        public string Telefone { get; set; }
    }
}
