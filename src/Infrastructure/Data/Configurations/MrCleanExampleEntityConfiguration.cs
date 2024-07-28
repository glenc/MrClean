using MrClean.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MrClean.Infrastructure.Data.Configurations;

public class MrCleanExampleEntityConfiguration : IEntityTypeConfiguration<MrCleanExampleEntity>
{
    public void Configure(EntityTypeBuilder<MrCleanExampleEntity> builder)
    {
        builder.Property(x => x.Name)
            .HasMaxLength(255)
            .IsRequired();
    }
}