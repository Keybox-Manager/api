﻿using KeyBoxAPI.Core.Interfaces.Markers;

namespace KeyBoxAPI.Core.Interfaces.Repositories;

public interface IRepository<T> where T : IModel
{
    Task AddAsync(T model);
    Task DeleteAsync(int id);
    Task<IEnumerable<T>> GetAsync();
    Task<T?> GetAsync(int id);
    Task UpdateAsync(T model);
}