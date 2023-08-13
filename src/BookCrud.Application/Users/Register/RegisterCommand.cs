using System.ComponentModel.DataAnnotations;
using MediatR;

namespace BookCrud.Application.Users.Register;

public record RegisterCommand(string Email, string Password) : IRequest<string>;

