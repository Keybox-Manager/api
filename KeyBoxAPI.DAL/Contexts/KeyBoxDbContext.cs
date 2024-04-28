using KeyBoxAPI.DAL.Configurations;
using KeyBoxAPI.DAL.Entites;
using Microsoft.EntityFrameworkCore;

namespace KeyBoxAPI.DAL.Contexts;

public sealed class KeyBoxDbContext : DbContext
{
    public KeyBoxDbContext(DbContextOptions<KeyBoxDbContext> options) : base(options) { }

    public DbSet<AccountEntity> AccountEntities { get; set; }
    public DbSet<CategoryEntity> CategoryEntities { get; set; }
    public DbSet<SubcategoryEntity> SubcategoryEntities { get; set; }
    public DbSet<UserEntity> UserEntities { get; set; }
    public DbSet<VaultEntity> VaultEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AccountConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new SubcategoryConfiguration());
        modelBuilder.ApplyConfiguration(new UserConfiguration());
        modelBuilder.ApplyConfiguration(new VaultConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}