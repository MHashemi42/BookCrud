using BookCrud.Application.Common.Interfaces;
using BookCrud.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace BookCrud.Infrastructure.Identity;

public class UserService : IUserService
{
    private readonly UserManager<ApplicationUser> _userManager;

    public UserService(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<bool> CheckPasswordAsync(string userName, string password)
    {
        ApplicationUser? user = await _userManager.FindByNameAsync(userName);
        if (user is null)
        {
            return false;
        }

        bool isPasswordValid = await _userManager.CheckPasswordAsync(user, password);

        return isPasswordValid;
    }

    public async Task<(Result Result, string UserId)> CreateUserAsync(string userName, string password)
    {
        var user = new ApplicationUser
        {
            UserName = userName,
            Email = userName,
        };

        var result = await _userManager.CreateAsync(user, password);

        return (result.ToApplicationResult(), user.Id);
    }

    public async Task<UserDto?> GetUserByEmailAsync(string userName)
    {
        ApplicationUser? applicationUser = await _userManager.FindByNameAsync(userName);
        UserDto? user = null;
        if (applicationUser is not null)
        {
            user = new UserDto(applicationUser.Id, applicationUser.Email!);
        }

        return user;
    }
}
