using BookCrud.Domain.Common;

namespace BookCrud.Domain.Entities;

public class Publisher : BaseEntity
{
    public required string Title { get; set; }

    public string? ImageUrl { get; set; }


    public required ICollection<Book> Books { get; set; }
}
