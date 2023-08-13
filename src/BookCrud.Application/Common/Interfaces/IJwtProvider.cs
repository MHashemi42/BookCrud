using BookCrud.Application.Common.Models;

namespace BookCrud.Application.Common.Interfaces;

public interface IJwtProvider
{
    string Generate(UserDto user);
}
