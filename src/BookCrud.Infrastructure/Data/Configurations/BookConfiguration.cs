using BookCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookCrud.Infrastructure.Data.Configurations;

public class BookConfiguration : IEntityTypeConfiguration<Book>
{
    public void Configure(EntityTypeBuilder<Book> builder)
    {
        builder.Property(b => b.Title)
            .HasMaxLength(200);

        builder.Property(b => b.Description)
            .HasMaxLength(2000);

        builder.Property(b => b.Isbn)
            .HasMaxLength(13);

        builder.Property(b => b.ImageUrl)
            .HasMaxLength(1000);

        builder.Property(b => b.PublishDate)
            .HasColumnType("date");
    }
}