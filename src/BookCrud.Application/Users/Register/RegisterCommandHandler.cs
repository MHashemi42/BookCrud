using BookCrud.Application.Common.Interfaces;
using BookCrud.Application.Common.Models;
using BookCrud.Application.Users.Exceptions;
using MediatR;

namespace BookCrud.Application.Users.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, string>
{
    private readonly IUserService _userService;

    public RegisterCommandHandler(IUserService userService)
    {
        _userService = userService;
    }

    public async Task<string> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        (Result result, string userId) = await _userService
            .CreateUserAsync(request.Email, request.Password);

        if (!result.Succeeded)
        {
            throw new RegisterUserFailedException(result.Errors);
        }

        return userId;
    }
}
