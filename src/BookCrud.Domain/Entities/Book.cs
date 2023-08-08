using BookCrud.Domain.Common;

namespace BookCrud.Domain.Entities;

public class Book : BaseEntity
{
    public required string Title { get; set; }

    public string? Description { get; set; }

    public required string Isbn { get; set; }

    public int Pages { get; set; }

    public string? ImageUrl { get; set; }

    public DateTime PublishDate { get; set; }

    public int AuthorId { get; set; }

    public int PublisherId { get; set; }


    public required Author Author { get; set; } 

    public required Publisher Publisher { get; set; } 

    public required ICollection<Category> Categories { get; set; }

}
