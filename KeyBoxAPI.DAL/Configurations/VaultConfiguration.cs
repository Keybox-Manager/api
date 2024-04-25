using KeyBoxAPI.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KeyBoxAPI.DAL.Configurations;

internal sealed class VaultConfiguration : IEntityTypeConfiguration<VaultEntity>
{
    public void Configure(EntityTypeBuilder<VaultEntity> builder)
    {
        builder.HasMany(x => x.CategoryEntities)
            .WithOne(x => x.VaultEntity)
            .HasForeignKey(x => x.VaultId);
    }
}