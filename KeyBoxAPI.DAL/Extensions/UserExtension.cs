using KeyBoxAPI.Core.Models;
using KeyBoxAPI.DAL.Entites;

namespace KeyBoxAPI.DAL.Extensions;

internal static class UserExtension
{
    public static User ToModel(this UserEntity entity)
        => new(
            entity.Id,
            entity.Name,
            entity.Password,
            entity.Email
        );

    public static IEnumerable<User> ToModels(this IEnumerable<UserEntity> entities)
        => entities.Select(x => x.ToModel());

    public static UserEntity FromModel(this User model)
        => new()
        {
            Id = model.Id,
            Name = model.Name,
            Password = model.Password,
            Email = model.Email
        };

    public static IEnumerable<UserEntity> FromModels(this IEnumerable<User> models)
        => models.Select(x => x.FromModel());
}