using gamezzzzz_be.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace gamezzzzz_be.Services;

public class GamesService
{
    private readonly IMongoCollection<Game> _gamesCollection;

    public GamesService(
        IOptions<GamezzzzzDatabaseSettings> gamezzzzzDatabaseSettings)
    {
        var mongoClient = new MongoClient(
            gamezzzzzDatabaseSettings.Value.ConnectionString);

        var mongoDatabase = mongoClient.GetDatabase(
            gamezzzzzDatabaseSettings.Value.DatabaseName);

        _gamesCollection = mongoDatabase.GetCollection<Game>(
            gamezzzzzDatabaseSettings.Value.GamesCollectionName);
    }

    public async Task<List<Game?>> GetAsync() =>
        await _gamesCollection.Find(_ => true).ToListAsync();

    public async Task<Game?> GetAsync(string id) =>
        await _gamesCollection.Find(x => x.Id == id).FirstOrDefaultAsync();

}
