using BookCrud.Application.Common.Models;

namespace BookCrud.Application.Common.Interfaces;

public interface IUserService
{
    Task<UserDto?> GetUserByEmailAsync(string Email);
    Task<bool> CheckPasswordAsync(string Email, string password);
    Task<(Result Result, string UserId)> CreateUserAsync(string Email, string password);
}
