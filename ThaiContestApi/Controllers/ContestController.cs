using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ThaiContestApi.Models.Entity;
using ThaiContestApi.Services;

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
        public IEnumerable<Contest> Get()
        {
            return _contestService.FindAll();
        }

        [HttpGet("{id}")]
        public ActionResult<Contest> Get(string id)
        {
            return _contestService.FindById(id);
        }

        [HttpPost]
        public void Post([FromBody] Contest contest)
        {
            _contestService.Create(contest);
        }

        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Contest contest)
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
