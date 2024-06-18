
using solution.Context;
using solution.Repositories.Abstract;

namespace solution.Repositories;

public class GenreRepository : BaseRepository, IGenreRepository
{

    public GenreRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        
    }
}