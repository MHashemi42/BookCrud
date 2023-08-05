using BookCrud.Domain.Common;

namespace BookCrud.Domain.Entities;

public class Publisher : BaseEntity
{
    public string Title { get; set; } = default!;

    public string? ImageUrl { get; set; }


    public ICollection<Book> Books { get; set; } = default!;
}
