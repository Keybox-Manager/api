using KeyBoxAPI.Core.Interfaces.Markers;

namespace KeyBoxAPI.Core.Models;

public sealed record Subcategory(
    int Id,
    int CategoryId,
    string Name,
    string? Url,
    string? Notes,
    string? Icon,
    Category Category
) : IModel;