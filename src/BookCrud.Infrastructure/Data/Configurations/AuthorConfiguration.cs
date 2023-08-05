using BookCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookCrud.Infrastructure.Data.Configurations;

public class AuthorConfiguration : IEntityTypeConfiguration<Author>
{
    public void Configure(EntityTypeBuilder<Author> builder)
    {
        builder.Property(a => a.Name)
            .HasMaxLength(200);

        builder.Property(a => a.Bio)
            .HasMaxLength(2000);

        builder.Property(a => a.ImageUrl)
            .HasMaxLength(1000);
    }
}
