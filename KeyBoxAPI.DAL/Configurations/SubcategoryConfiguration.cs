using KeyBoxAPI.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KeyBoxAPI.DAL.Configurations;

internal sealed class SubcategoryConfiguration : IEntityTypeConfiguration<SubcategoryEntity>
{
    public void Configure(EntityTypeBuilder<SubcategoryEntity> builder)
    {
        builder.HasMany(x => x.AccountEntities)
            .WithOne(x => x.SubcategoryEntity)
            .HasForeignKey(x => x.SubcategoryId);
    }
}