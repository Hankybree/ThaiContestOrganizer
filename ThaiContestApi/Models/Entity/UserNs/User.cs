using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ThaiContestApi.Models.Entity.UserNs
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
    }
}
