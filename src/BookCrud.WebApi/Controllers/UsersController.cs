using BookCrud.Application;
using BookCrud.Application.Users.Login;
using BookCrud.Application.Users.Register;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookCrud.WebApi;

[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    private readonly ISender _sender;

    public UsersController(ISender sender)
    {
        _sender = sender;
    }

    [HttpPost("/register")]
    public async Task<IActionResult> RegisterUser(
        [FromBody] RegisterRequest request,
        CancellationToken cancellationToken)
    {
        var command = new RegisterCommand(request.Email, request.Password);

        string userId = await _sender.Send(command, cancellationToken);

        return Ok(userId);
    }

    [HttpPost("/login")]
    public async Task<IActionResult> LoginUser(
        [FromBody] LoginRequest request,
        CancellationToken cancellationToken)
    {
        var command = new LoginCommand(request.Email, request.Password);

        string token = await _sender.Send(command, cancellationToken);

        return Ok(token);
    }
}
