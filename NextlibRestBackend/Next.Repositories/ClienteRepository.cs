using MongoDB.Bson;
using MongoDB.Driver;
using Next.Models;
using System.Collections.Generic;
using System.Linq;

namespace Next.Repositories
{
    public class ClienteRepository
    {
        MongoClient _client;
        IMongoDatabase _db;

        public ClienteRepository()
        {
            _client = new MongoClient("mongodb://senac:1234@ds161164.mlab.com:61164/nextlib-spring");
            _db = _client.GetDatabase("nextlib-spring");
        }

        public IEnumerable<Cliente> GetClientes()
        {
            return _db.GetCollection<Cliente>("cliente").AsQueryable();
        }

        public Cliente GetCliente(string id)
        {
            return _db.GetCollection<Cliente>("cliente")
                .Find(Builders<Cliente>.Filter.Eq(c => c.Id, ObjectId.Parse(id)))
                .FirstOrDefault();
        }
    }
}
