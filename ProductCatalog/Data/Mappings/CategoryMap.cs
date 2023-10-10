using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ProductCatalog.Data.Mappings;

public class CategoryMap : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category));

        builder.HasKey(x => x.Id);

        builder.Property(c => c.Title)
            .IsRequired()
            .HasMaxLength(120)
            .HasColumnType("varchar(120)");
    }
}
