using BookCrud.Domain.Common;

namespace BookCrud.Domain.Entities;

public class Book : BaseEntity
{
    public string Title { get; set; } = default!;

    public string? Description { get; set; }

    public string Isbn { get; set; } = default!;

    public int Pages { get; set; }

    public string? ImageUrl { get; set; }

    public DateTime PublishDate { get; set; }

    public int AuthorId { get; set; }

    public int PublisherId { get; set; }


    public Author Author { get; set; } = default!;

    public Publisher Publisher { get; set; } = default!;

    public ICollection<Category> Categories { get; set; } = default!;

}
