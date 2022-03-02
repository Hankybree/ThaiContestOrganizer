using System.Collections.Generic;
using ThaiContestApi.Models.Entity;

namespace ThaiContestApi.Services
{
    public interface IContestService
    {
        List<Contest> FindAll();

        Contest FindById(string id);

        void Create(Contest contest);

        void Update(string id, Contest contest);

        void Delete(string id);
    }
}
