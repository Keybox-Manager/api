using KeyBoxAPI.Core.Models;
using KeyBoxAPI.DAL.Entites;

namespace KeyBoxAPI.DAL.Extensions;

internal static class VaultExtension
{
    public static Vault ToModel(this VaultEntity entity)
        => new(
            entity.Id,
            entity.UserId,
            entity.Name,
            entity.UserEntity.ToModel()
        );

    public static IEnumerable<Vault> ToModels(this IEnumerable<VaultEntity> entities)
        => entities.Select(x => x.ToModel());

    public static VaultEntity FromModel(this Vault model)
        => new()
        {
            Id = model.Id,
            UserId = model.UserId,
            Name = model.Name
        };

    public static IEnumerable<VaultEntity> FromModels(this IEnumerable<Vault> models)
        => models.Select(x => x.FromModel());
}