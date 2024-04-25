namespace KeyBoxAPI.DAL.Entites;

public sealed class SubcategoryEntity
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Url { get; set; }
    public string? Notes { get; set; }
    public string? Icon { get; set; }
    public CategoryEntity CategoryEntity { get; set; } = new();
    public ICollection<AccountEntity> AccountEntities { get; set; } = [];
}