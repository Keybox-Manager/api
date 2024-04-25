using KeyBoxAPI.Core.Interfaces.Markers;

namespace KeyBoxAPI.Core.Interfaces.Services;

public interface IService<T> where T : IModel
{
    Task AddAsync(T model);
    Task DeleteAsync(int id);
    Task<IEnumerable<T>> GetAsync();
    Task<T?> GetAsync(int id);
    Task UpdateAsync(T model);
}