using solution.Context;
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