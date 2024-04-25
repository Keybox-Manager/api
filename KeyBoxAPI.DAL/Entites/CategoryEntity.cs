namespace KeyBoxAPI.DAL.Entites;

public sealed class CategoryEntity
{
    public int Id { get; set; }
    public int VaultId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public VaultEntity VaultEntity { get; set; } = new();
    public ICollection<SubcategoryEntity> SubcategoryEntities { get; set; } = [];
}