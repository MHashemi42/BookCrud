using MediatR;

namespace BookCrud.Application.Users.Login;

public record LoginCommand(string Email, string Password) : IRequest<string>;
