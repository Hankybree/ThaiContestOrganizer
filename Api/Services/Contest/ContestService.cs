using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Models.Dto;
using Api.Models.Entity;
using Api.Repository.ContestNs;

namespace Api.Services.ContestNs
{
    public class ContestService : IContestService
    {
        private readonly IContestRepository _contestRepository;

        public ContestService(IContestRepository contestRepository)
        {
            _contestRepository = contestRepository;
        }

        public async Task<IEnumerable<ContestDto>> FindAll()
        {
            List<ContestDto> contestDtos = new();

            IEnumerable<Contest> contests = await _contestRepository.FindAll();

            foreach (Contest contest in contests)
            {
                contestDtos.Add(new ContestDto()
                {
                    Name = contest.Name,
                    OccursAt = contest.OccursAt
                });
            }

            return contestDtos;
        }

        public async Task<ContestDto> FindById(string id)
        {
            throw new NotImplementedException();
        }

        public async Task Create(ContestDto contestDto)
        {
            await _contestRepository.Create(new Contest(DateTime.Now, null, contestDto.Name, contestDto.OccursAt));
        }

        public async Task Update(string id, ContestDto contestDto)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}
