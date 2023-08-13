using System.ComponentModel.DataAnnotations;

namespace BookCrud.Application.Users.Register;

public record RegisterRequest(string Email, string Password);
