using KeyBoxAPI.Core.Models;
using KeyBoxAPI.DAL.Entites;

namespace KeyBoxAPI.DAL.Extensions;

internal static class AccountExtension
{
    public static Account ToModel(this AccountEntity entity)
        => new(
            entity.Id,
            entity.SubcategoryId,
            entity.Login,
            entity.Email,
            entity.Password,
            entity.DateAdd,
            entity.DateUpdate,
            entity.SubcategoryEntity.ToModel()
        );

    public static IEnumerable<Account> ToModels(this IEnumerable<AccountEntity> entities)
        => entities.Select(x => x.ToModel());

    public static AccountEntity FromModel(this Account model)
        => new()
        {
            Id = model.Id,
            SubcategoryId = model.SubcategoryId,
            Login = model.Login,
            Email = model.Email,
            Password = model.Password,
            DateAdd = model.DateAdd,
            DateUpdate = model.DateUpdate
        };

    public static IEnumerable<AccountEntity> FromModels(this IEnumerable<Account> models)
        => models.Select(x => x.FromModel());
}