using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MongoDb.Core
{
    public class UserService
    {
        private IMongoCollection<User> _users;
        private FilterDefinitionBuilder<User> _filterBuilder;
        public UserService(IMongoDbSettings settings)
        {
            _filterBuilder = Builders<User>.Filter;
            MongoClient client = new MongoClient(settings.ConnectionString);
            var db = client.GetDatabase(settings.Database);
            _users = db.GetCollection<User>(settings.Collection);
        }

        public List<User> GetAll() => _users.Find(Builders<User>.Filter.Empty).ToList();

        public User GetSingle(int id)
        {
            var filter = _filterBuilder.Eq(x => x.Id, id);
            return _users.Find(filter).FirstOrDefault();
        }
    }
}