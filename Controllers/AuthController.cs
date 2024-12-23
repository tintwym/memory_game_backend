using Microsoft.AspNetCore.Mvc;

namespace memory_game_backend.Controllers;

using Microsoft.AspNetCore.Mvc;

using Models.DTOs.Requests;
using Services.Interfaces;

[ApiController]
[Route("api/auth")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;
    
    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login(UserRequest.Login request)
    {
        var response = await _userService.Login(request);
        
        return Ok(response);
    }
    
    [HttpPost("register")]
    public async Task<IActionResult> Register(UserRequest.Create request)
    {
        var response = await _userService.Create(request);
        
        return Ok(response);
    }
}