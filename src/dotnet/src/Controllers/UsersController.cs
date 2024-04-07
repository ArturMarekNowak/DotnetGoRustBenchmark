using App.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

public sealed class UsersController : ControllerBase
{
    private readonly UsersService _usersService;

    public UsersController(UsersService usersService)
    {
        _usersService = usersService;
    }
    
    [HttpGet("users/{id:int}")]
    public async Task<IActionResult> GetUserAsync(int id)
    {
        var user = await _usersService.GetUser(id);

        return user is not null ? Ok(user) : NotFound(id);
    }
}