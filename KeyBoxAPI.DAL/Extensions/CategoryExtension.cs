using KeyBoxAPI.Core.Models;
using KeyBoxAPI.DAL.Entites;

namespace KeyBoxAPI.DAL.Extensions;

internal static class CategoryExtension
{
    public static Category ToModel(this CategoryEntity entity)
        => new(
            entity.Id,
            entity.VaultId,
            entity.Name,
            entity.Description,
            entity.VaultEntity.ToModel()
        );

    public static IEnumerable<Category> ToModels(this IEnumerable<CategoryEntity> entities)
        => entities.Select(x => x.ToModel());

    public static CategoryEntity FromModel(this Category model)
        => new()
        {
            Id = model.Id,
            VaultId = model.VaultId,
            Name = model.Name,
            Description = model.Description
        };

    public static IEnumerable<CategoryEntity> FromModels(this IEnumerable<Category> models)
        => models.Select(x => x.FromModel());
}