using MongoDB.Bson;
using MongoDB.Driver;
using Next.Models;
using System.Collections.Generic;
using System.Linq;

namespace Next.Repositories
{
    public class Repository<T> where T : ICollection
    {
        MongoClient _client;
        IMongoDatabase _db;

        public Repository()
        {
            _client = new MongoClient("mongodb://senac:1234@ds127536.mlab.com:27536/nextlib-dotnet");
            _db = _client.GetDatabase("nextlib-dotnet");
        }

        public IList<T> Get()
        {
            return _db.GetCollection<T>(typeof(T).Name).AsQueryable().ToList();
        }

        public T Get(string id)
        {
            return _db.GetCollection<T>(typeof(T).Name)
                .Find(Builders<T>.Filter.Eq(c => c.Id, ObjectId.Parse(id)))
                .FirstOrDefault();
        }

        public void Create(T item)
        {
            _db.GetCollection<T>(typeof(T).Name).InsertOne(item);
        }

        public void Update(T item, string id)
        {
            item.Id = ObjectId.Parse(id);
            _db.GetCollection<T>(typeof(T).Name).ReplaceOne(new BsonDocument("_id", ObjectId.Parse(id)), item);
        }

        public void Delete(string id)
        {
            _db.GetCollection<T>(typeof(T).Name).DeleteOne(new BsonDocument("_id", ObjectId.Parse(id)));
        }
    }
}
