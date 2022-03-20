using System.Collections.Generic;
using System.Threading.Tasks;
using ThaiContestApi.Models.Entity;

namespace ThaiContestApi.Repository.ContestNs
{
    public interface IContestRepository
    {
        Task<IEnumerable<Contest>> FindAll();

        Task<Contest> FindById(string id);

        Task Create(Contest contest);

        Task Update(string id, Contest contest);

        Task Delete(string id);
    }
}
