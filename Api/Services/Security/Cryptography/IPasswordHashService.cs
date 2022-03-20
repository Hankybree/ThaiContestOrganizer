using System;
using ThaiContestApi.Models.Entity.UserNs;

namespace ThaiContestApi.Services.Security.Cryptography
{
    public interface IPasswordHashService
    {
        Password HashPassword(string password);

        bool VerifyPassword(string password, Password hashedPassword);
    }
}
