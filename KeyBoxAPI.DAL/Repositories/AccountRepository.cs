using KeyBoxAPI.Core.Interfaces.Repositories;
using KeyBoxAPI.Core.Models;
using KeyBoxAPI.DAL.Contexts;
using KeyBoxAPI.DAL.Extensions;
using Microsoft.EntityFrameworkCore;

namespace KeyBoxAPI.DAL.Repositories;

public sealed class AccountRepository : IRepository<Account>
{
    private readonly KeyBoxDbContext _context;

    public AccountRepository(KeyBoxDbContext context)
    {
        _context = context;
    }

    public async Task AddAsync(Account model)
    {
        await _context.AddAsync(model.FromModel());
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        await _context.AccountEntities
            .Where(x => x.Id == id)
            .ExecuteDeleteAsync();
    }

    public async Task<IEnumerable<Account>> GetAsync()
    {
        return (await _context.AccountEntities
            .AsNoTracking()
            .Include(x => x.SubcategoryEntity)
            .ToListAsync())
            .ToModels();
    }

    public async Task<Account?> GetAsync(int id)
    {
        return (await _context.AccountEntities
            .AsNoTracking()
            .Include(x => x.SubcategoryEntity)
            .FirstOrDefaultAsync(x => x.Id == id))?
            .ToModel();
    }

    public async Task UpdateAsync(Account model)
    {
        await _context.AccountEntities
            .Where(w => w.Id == model.Id)
            .ExecuteUpdateAsync(e => e
                .SetProperty(p => p.SubcategoryId, model.SubcategoryId)
                .SetProperty(p => p.Login, model.Login)
                .SetProperty(p => p.Email, model.Email)
                .SetProperty(p => p.Password, model.Password)
                .SetProperty(p => p.DateAdd, model.DateAdd)
                .SetProperty(p => p.DateUpdate, model.DateUpdate)
            );
    }
}