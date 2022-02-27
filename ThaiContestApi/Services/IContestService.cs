using System;
using System.Collections.Generic;
using ThaiContestApi.Models;

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
