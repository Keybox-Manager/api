namespace KeyBoxAPI.DAL.Entites;

public sealed class AccountEntity
{
    public int Id { get; set; }
    public int SubcategoryId { get; set; }
    public string Login { get; set; } = string.Empty;
    public string? Email { get; set; }
    public string Password { get; set; } = string.Empty;
    public DateTime DateAdd { get; set; }
    public DateTime DateUpdate { get; set; }
    public SubcategoryEntity SubcategoryEntity { get; set; } = new();
}