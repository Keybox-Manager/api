using KeyBoxAPI.Core.Interfaces.Markers;

namespace KeyBoxAPI.Core.Models;

public sealed record Category(
    int Id,
    int VaultId,
    string Name,
    string? Description,
    Vault Vault
) : IModel;
