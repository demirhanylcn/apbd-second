using Microsoft.EntityFrameworkCore;
using solution.Context;
using solution.Models.Domain;
using solution.Models.Request;
using solution.Models.Response;
using solution.Repositories.Abstract;

namespace solution.Repositories;

public abstract class BaseRepository : IBaseRepository
{
    protected readonly AppDbContext _appDbContext;

    public BaseRepository(AppDbContext appDbContext)
    {
        _appDbContext = appDbContext;
    }

    public async Task SaveChangesAsync()
    {
        await _appDbContext.SaveChangesAsync();
    }

    
}