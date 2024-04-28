using KeyBoxAPI.Core.Models;
using KeyBoxAPI.DAL.Entites;

namespace KeyBoxAPI.DAL.Extensions;

internal static class SubcategoryExtension
{
    public static Subcategory ToModel(this SubcategoryEntity entity)
        => new(
            entity.Id,
            entity.CategoryId,
            entity.Name,
            entity.Url,
            entity.Notes,
            entity.Icon,
            entity.CategoryEntity.ToModel()
        );

    public static IEnumerable<Subcategory> ToModels(this IEnumerable<SubcategoryEntity> entities)
        => entities.Select(x => x.ToModel());

    public static SubcategoryEntity FromModel(this Subcategory model)
        => new()
        {
            Id = model.Id,
            CategoryId = model.CategoryId,
            Name = model.Name,
            Url = model.Url,
            Notes = model.Notes,
            Icon = model.Icon
        };

    public static IEnumerable<SubcategoryEntity> FromModels(this IEnumerable<Subcategory> models)
        => models.Select(x => x.FromModel());
}