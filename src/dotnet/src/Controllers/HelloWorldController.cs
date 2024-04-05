using Microsoft.AspNetCore.Mvc;

namespace App.Controllers;

public sealed class HelloWorldController : ControllerBase
{
    [HttpGet("helloWorld")]
    public async Task<string> GetHelloWorld()
    {
        return "{\"message\": \"Hello World!\"}";
    }
}