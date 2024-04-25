using KeyBoxAPI.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KeyBoxAPI.DAL.Configurations;

internal sealed class CategoryConfiguration : IEntityTypeConfiguration<CategoryEntity>
{
    public void Configure(EntityTypeBuilder<CategoryEntity> builder)
    {
        builder.HasMany(x => x.SubcategoryEntities)
            .WithOne(x => x.CategoryEntity)
            .HasForeignKey(x => x.CategoryId);
    }
}