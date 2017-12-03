using MongoDB.Bson;
using MongoDB.Driver;
using Next.Models;
using System.Collections.Generic;
using System.Linq;

namespace Next.Repositories
{
    public class RegraRepository
    {
        MongoClient _client;
        IMongoDatabase _db;

        public RegraRepository()
        {
            _client = new MongoClient("mongodb://senac:1234@ds161164.mlab.com:61164/nextlib-spring");
            _db = _client.GetDatabase("nextlib-spring");
        }

        public IEnumerable<Regra> GetRegras()
        {
            return _db.GetCollection<Regra>("regra").AsQueryable();
        }

        public Regra GetRegra(string id)
        {
            return _db.GetCollection<Regra>("regra")
                .Find(Builders<Regra>.Filter.Eq(c => c.Id, ObjectId.Parse(id)))
                .FirstOrDefault();
        }
    }
}
