using BookCrud.Application.Common.Exceptions;

namespace BookCrud.Application.Users.Exceptions;

public class RegisterUserFailedException : ValidationException
{
    public RegisterUserFailedException(IEnumerable<string> errors)
        : base()
    {
        Errors.Add("User", (string[])errors);
    }
}
