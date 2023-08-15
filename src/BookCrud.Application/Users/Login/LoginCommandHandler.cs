using BookCrud.Application.Common.Interfaces;
using BookCrud.Application.Common.Models;
using BookCrud.Application.Users.Exceptions;
using MediatR;

namespace BookCrud.Application.Users.Login;

internal class LoginCommandHandler : IRequestHandler<LoginCommand, string>
{
    private readonly IUserService _userService;
    private readonly IJwtProvider _jwtProvider;

    public LoginCommandHandler(IUserService userService, IJwtProvider jwtProvider)
    {
        _userService = userService;
        _jwtProvider = jwtProvider;
    }

    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        UserDto? user = await _userService.GetUserByEmailAsync(request.Email);
        if (user is null)
        {
            throw new InvalidEmailOrPasswordException();
        }

        bool isPasswordValid = await _userService.CheckPasswordAsync(request.Email, request.Password);
        if (!isPasswordValid)
        {
            throw new InvalidEmailOrPasswordException();
        }

        string token = _jwtProvider.Generate(user);
        
        return token;
    }
}
