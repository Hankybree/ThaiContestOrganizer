using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MongoDB.Driver;
using ThaiContestApi.Models.Entity;
using ThaiContestApi.Repository.MongoConnectionNs;

namespace ThaiContestApi.Repository.ContestNs
{
    public class ContestRepository : IContestRepository
    {
        private readonly IMongoCollection<Contest> _contestCollection;

        public ContestRepository(IMongoRepository mongoRepository)
        {
            _contestCollection = mongoRepository.ContestCollection;
        }

        public async Task<IEnumerable<Contest>> FindAll()
        {
            return await _contestCollection.Find(contest => true).ToListAsync();
        }

        public async Task<Contest> FindById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Create(Contest contest)
        {
            await _contestCollection.InsertOneAsync(contest);
        }

        public async Task Update(string id, Contest contest)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
