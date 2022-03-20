using System;
using MongoDB.Driver;
using Api.Models.Entity;

namespace Api.Config.Mongo
{
    public interface IMongoConfig
    {
        IMongoCollection<Contest> ContestCollection { get; }
    }
}
