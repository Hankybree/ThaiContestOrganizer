using System;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using Api.Models.Entity.UserNs;

namespace Api.Services.Security.Cryptography
{
    public class PasswordHashService : IPasswordHashService
    {
        public Password HashPassword(string password)
        {
            byte[] salt = GenerateSalt();

            string hash = GenerateHash(password, salt);

            return new Password(hash, salt);
        }

        public bool VerifyPassword(string enteredPassword, Password userPassword)
        {
            string hash = GenerateHash(enteredPassword, userPassword.Salt);

            return hash == userPassword.Hash;
        }

        private byte[] GenerateSalt()
        {
            const int saltSize = 128 / 8; // 128 bits

            // generate a 128-bit salt using a cryptographically strong random sequence of nonzero values
            byte[] salt = new byte[saltSize];
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                rngCsp.GetNonZeroBytes(salt);
            }

            return salt;
        }

        private string GenerateHash(string password, byte[] salt)
        {
            const int iterations = 100000;
            const int keyLength = 256 / 8;

            // derive a 256-bit subkey (use HMACSHA256 with 100,000 iterations)
            string hash = Convert.ToBase64String(KeyDerivation.Pbkdf2(
                password: password,
                salt: salt,
                prf: KeyDerivationPrf.HMACSHA256,
                iterationCount: iterations,
                numBytesRequested: keyLength));

            return hash;
        }
    }
}
