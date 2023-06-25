using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace gamezzzzz_be.Models;

public class Game
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    [BsonElement("Name")]
    public string GameName { get; set; } = null!;

    public string ReleaseDate { get; set; } = null!;

    public decimal Price { get; set; }

    public string About { get; set; } = null!;

    public string Genres { get; set; } = null!;

    public string Image { get; set; } = null!;
}
