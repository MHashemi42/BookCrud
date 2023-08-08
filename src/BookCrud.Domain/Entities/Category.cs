using BookCrud.Domain.Common;

namespace BookCrud.Domain.Entities;

public class Category : BaseEntity
{
    public required string Title { get; set; }


    public required ICollection<Book> Books { get; set; }
}
