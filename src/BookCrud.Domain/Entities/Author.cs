using BookCrud.Domain.Common;

namespace BookCrud.Domain.Entities;

public class Author : BaseEntity
{
    public string Name { get; set; } = default!;

    public string? Bio { get; set; }

    public string? ImageUrl { get; set; }


    public ICollection<Book> Books { get; set; } = default!;
}
