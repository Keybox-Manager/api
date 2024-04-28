using KeyBoxAPI.Core.Interfaces.Repositories;
using KeyBoxAPI.Core.Interfaces.Services;
using KeyBoxAPI.Core.Models;

namespace KeyBoxAPI.Application.Services;

public sealed class AccountService : IService<Account>
{
    private readonly IRepository<Account> _repository;

    public AccountService(IRepository<Account> repository)
    {
        _repository = repository;
    }

    public async Task AddAsync(Account model)
    {
        await _repository.AddAsync(model);
    }

    public async Task DeleteAsync(int id)
    {
        await _repository.DeleteAsync(id);
    }

    public async Task<IEnumerable<Account>> GetAsync()
    {
        return await _repository.GetAsync();
    }

    public async Task<Account?> GetAsync(int id)
    {
        return await _repository.GetAsync(id);
    }

    public async Task UpdateAsync(Account model)
    {
        await _repository.UpdateAsync(model);
    }
}