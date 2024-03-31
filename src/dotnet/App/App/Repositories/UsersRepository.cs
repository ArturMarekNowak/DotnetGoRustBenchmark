using App.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace App.Repositories;

public sealed class UsersRepository
{
    private readonly IMongoCollection<User> _usersCollection;
    
    public UsersRepository(IOptions<DatabasesConfiguration> databaseConfiguration)
    {
        var mongoClient = new MongoClient(databaseConfiguration.Value.UsersDb!.ConnectionString);
        var mongoDatabase = mongoClient.GetDatabase(databaseConfiguration.Value.UsersDb.DatabaseName);
        _usersCollection = mongoDatabase.GetCollection<User>(databaseConfiguration.Value.UsersDb.CollectionName);
    }
    
    public async Task<User?> GetUser(int id, CancellationToken cancellationToken)
    {
        var user = await _usersCollection
            .Find(u => u.Id == id)
            .FirstOrDefaultAsync(cancellationToken: cancellationToken);
        
        return user;
    }
}