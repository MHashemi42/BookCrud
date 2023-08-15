using BookCrud.Application.Common.Exceptions;

namespace BookCrud.Application.Users.Exceptions;

public class InvalidEmailOrPasswordException : ValidationException
{
    public InvalidEmailOrPasswordException()
        : base()
    {
        Errors.Add("User", new string[] { "Invalid email or password."});
    }
}
