using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace ThaiContestApi.Models.Entity
{
    public class Contest
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public string Name { get; set; }
        public DateTime OccursAt { get; set; }

        public Contest(DateTime createdAt, DateTime? updatedAt, string name, DateTime occursAt)
        {
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            Name = name;
            OccursAt = occursAt;
        }
    }
}
