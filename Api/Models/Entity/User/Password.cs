using System;
namespace Api.Models.Entity.UserNs
{
    public class Password
    {
        public string Hash { get; set; }
        public byte[] Salt { get; set; }

        public Password(string hash, byte[] salt)
        {
            Hash = hash;
            Salt = salt;
        }
    }
}
