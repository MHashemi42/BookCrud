using BookCrud.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BookCrud.Infrastructure.Data.Configurations;

public class PublisherConfiguration : IEntityTypeConfiguration<Publisher>
{
    public void Configure(EntityTypeBuilder<Publisher> builder)
    {
        builder.Property(p => p.Title)
            .HasMaxLength(200);

        builder.Property(p => p.ImageUrl)
            .HasMaxLength(1000);
    }
}
