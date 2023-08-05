using BookCrud.Domain.Common;

namespace BookCrud.Domain.Entities;

public class Category : BaseEntity
{
    public string Title { get; set; } = default!;


    public ICollection<Book> Books { get; set; } = default!;
}
