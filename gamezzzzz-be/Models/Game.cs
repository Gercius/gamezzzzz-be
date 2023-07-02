using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace gamezzzzz_be.Models;

[BsonIgnoreExtraElements]
public class Game
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    [BsonElement("Name")]
    public string GameName { get; set; }

    [BsonElement("Release date")]
    public string ReleaseDate { get; set; } = null!;

    public decimal Price { get; set; }

    [BsonElement("About the game")]
    public string About { get; set; } = null!;

    public string Genres { get; set; } = null!;

    [BsonElement("Header image")]
    public string Image { get; set; } = null!;
}

