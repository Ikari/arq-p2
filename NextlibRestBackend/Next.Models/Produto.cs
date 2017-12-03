using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Next.Models
{
    public class Produto
    {
        public ObjectId Id { get; set; }
        public string OuterId { get { return Id.ToString(); } }
        [BsonElement("nome")]
        public string Nome { get; set; }
        [BsonElement("descricao")]
        public string Descricao { get; set; }
        [BsonElement("preco")]
        public double Preco { get; set; }
        [BsonElement("thumbnail")]
        public byte[] Thumb { get; set; }
        [BsonElement("imagem")]
        public byte[] Imagem { get; set; }

        [BsonElement("_class")]
        private string Class { get; set; }
    }
}
