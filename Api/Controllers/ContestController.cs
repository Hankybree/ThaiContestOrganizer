using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ThaiContestApi.Models.Dto;
using ThaiContestApi.Services.ContestNs;

namespace ThaiContestApi.Controllers
{
    [Route("api/v1/contest")]
    public class ContestController : Controller
    {
        private readonly IContestService _contestService;

        public ContestController(IContestService contestService)
        {
            _contestService = contestService;
        }

        [HttpGet]
        public async Task<IEnumerable<ContestDto>> Get()
        {
            return await _contestService.FindAll();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ContestDto>> Get(string id)
        {
            return await _contestService.FindById(id);
        }

        [HttpPost]
        public async Task Post([FromBody] ContestDto contest)
        {
            await _contestService.Create(contest);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody] ContestDto contest)
        {
            _contestService.Update(id, contest);
        }

        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            _contestService.Delete(id);
        }
    }
}
