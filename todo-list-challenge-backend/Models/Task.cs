using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel.DataAnnotations;

namespace todo_list_challenge_backend.Models
{
    public class TaskRepository
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public bool completed { get; set; }
        [Required]
        public DateTime createdAt { get; set; }
    }
}
