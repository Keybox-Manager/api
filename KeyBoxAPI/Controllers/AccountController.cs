using KeyBoxAPI.Core.Interfaces.Services;
using KeyBoxAPI.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace KeyBoxAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public sealed class AccountController : ControllerBase
{
    private readonly IService<Account> _service;

    public AccountController(IService<Account> service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task AddAsync([FromBody] Account model)
    {
        await _service.AddAsync(model);
    }

    [HttpDelete("{id}")]
    public async Task DeleteAsync(int id)
    {
        await _service.DeleteAsync(id);
    }

    [HttpGet]
    public async Task<IEnumerable<Account>> GetAsync()
    {
        return await _service.GetAsync();
    }

    [HttpGet("{id}")]
    public async Task<Account?> GetAsync(int id)
    {
        return await _service.GetAsync(id);
    }

    [HttpPut]
    public async Task UpdateAsync([FromBody] Account model)
    {
        await _service.UpdateAsync(model);
    }
}