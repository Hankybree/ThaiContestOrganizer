using System;
using Api.Models.Entity.UserNs;

namespace Api.Services.Security.Cryptography;

public interface IPasswordHashService
{
    Password HashPassword(string password);

    bool VerifyPassword(string password, Password hashedPassword);
}
