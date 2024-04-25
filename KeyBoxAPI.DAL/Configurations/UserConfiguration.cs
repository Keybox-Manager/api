using KeyBoxAPI.DAL.Entites;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace KeyBoxAPI.DAL.Configurations;

internal sealed class UserConfiguration : IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder.HasMany(x => x.VaultEntities)
            .WithOne(x => x.UserEntity)
            .HasForeignKey(x => x.UserId);
    }
}