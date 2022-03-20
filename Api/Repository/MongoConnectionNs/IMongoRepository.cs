using System;
using MongoDB.Driver;
using ThaiContestApi.Models.Entity;

namespace ThaiContestApi.Repository.MongoConnectionNs
{
    public interface IMongoRepository
    {
        IMongoCollection<Contest> ContestCollection { get; }
    }
}
