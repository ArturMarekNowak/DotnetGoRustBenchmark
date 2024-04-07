using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ThirdParty.Json.LitJson;

namespace App.Models;

public sealed class User
{
    [BsonId]
    public int Id { get; set; }
    [BsonElement("name")]
    public string? Name { get; set;  }
    [BsonElement("surname")]
    public string? Surname { get; set; }
    [BsonElement("email")]
    public string? Email { get; set;  }
}