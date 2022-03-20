using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Api.Models.Entity.UserNs
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public string Email { get; set; }
        public Password Password { get; set; }
        
        public User(DateTime createdAt, DateTime updatedAt, string email, Password password)
        {
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Email = email;
            Password = password;
        }
    }
}
