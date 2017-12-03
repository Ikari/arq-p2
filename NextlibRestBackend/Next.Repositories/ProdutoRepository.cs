using MongoDB.Bson;
using MongoDB.Driver;
using Next.Models;
using System.Collections.Generic;
using System.Linq;

namespace Next.Repositories
{
    public class ProdutoRepository
    {
        MongoClient _client;
        IMongoDatabase _db;

        public ProdutoRepository()
        {
            _client = new MongoClient("mongodb://senac:1234@ds161164.mlab.com:61164/nextlib-spring");
            _db = _client.GetDatabase("nextlib-spring");
        }

        public IEnumerable<Produto> GetProdutos()
        {
            return _db.GetCollection<Produto>("produto").AsQueryable();
        }

        public Produto GetProduto(string id)
        {
            return _db.GetCollection<Produto>("produto")
                .Find(Builders<Produto>.Filter.Eq(c => c.Id, ObjectId.Parse(id)))
                .FirstOrDefault();
        }
    }
}
