using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models.Dto;
using Api.Models.Entity;

namespace Api.Services.ContestNs
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
