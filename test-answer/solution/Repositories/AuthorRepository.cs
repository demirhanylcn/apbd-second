using solution.Context;
using solution.Repositories.Abstract;

namespace solution.Repositories;

public class AuthorRepository : BaseRepository, IAuthorRepository
{
    public AuthorRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        
    }
}