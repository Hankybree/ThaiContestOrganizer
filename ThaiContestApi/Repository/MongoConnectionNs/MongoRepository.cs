using System;
using MongoDB.Driver;
using ThaiContestApi.Config;
using ThaiContestApi.Models.Entity;

namespace ThaiContestApi.Repository.MongoConnectionNs
{
    public class MongoRepository : IMongoRepository
    {
        private readonly MongoClient _client;
        private readonly IMongoDatabase _database;

        private readonly IMongoCollection<Contest> _contestColletion;

        public MongoRepository(IMongoConfig mongoConfig)
        {
            _client = new MongoClient(mongoConfig.ConnectionString);
            _database = _client.GetDatabase(mongoConfig.DatabaseName);

            _contestColletion = _database.GetCollection<Contest>(mongoConfig.ContestCollection);
        }

        public IMongoCollection<Contest> ContestCollection => _contestColletion;
    }
}
