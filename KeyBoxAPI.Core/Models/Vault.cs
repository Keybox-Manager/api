using KeyBoxAPI.Core.Interfaces.Markers;

namespace KeyBoxAPI.Core.Models;

public sealed record Vault(
    int Id,
    int UserId,
    string Name,
    User User
) : IModel;