namespace KeyBoxAPI.DAL.Entites;

public sealed class VaultEntity
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public UserEntity UserEntity { get; set; } = new();
    public ICollection<CategoryEntity> CategoryEntities { get; set; } = [];
}