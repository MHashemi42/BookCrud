using BookCrud.Domain.Common;

namespace BookCrud.Domain.Entities;

public class Author : BaseEntity
{
    public required string Name { get; set; }

    public string? Bio { get; set; }

    public string? ImageUrl { get; set; }


    public required ICollection<Book> Books { get; set; }
}
