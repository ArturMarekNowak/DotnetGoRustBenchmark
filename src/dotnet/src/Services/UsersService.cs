using App.Models;
using App.Repositories;

namespace App.Services;

public sealed class UsersService
{
    private readonly UsersRepository _usersRepository;

    public UsersService(UsersRepository usersRepository)
    {
        _usersRepository = usersRepository;
    }

    public async Task<User?> GetUser(int id)
    {
        return await _usersRepository.GetUser(id, CancellationToken.None);
    }
}