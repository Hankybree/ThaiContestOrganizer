using System.Collections.Generic;
using System.Threading.Tasks;
using ThaiContestApi.Models.Dto;
using ThaiContestApi.Models.Entity;

namespace ThaiContestApi.Services.ContestNs
{
    public interface IContestService
    {
        Task<IEnumerable<ContestDto>> FindAll();

        Task<ContestDto> FindById(string id);

        Task Create(ContestDto contestDto);

        Task Update(string id, ContestDto contestDto);

        Task Delete(string id);
    }
}
