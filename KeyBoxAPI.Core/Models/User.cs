using KeyBoxAPI.Core.Interfaces.Markers;

namespace KeyBoxAPI.Core.Models;

public sealed record User(
    int Id,
    string Name,
    string Password,
    string Email
) : IModel;