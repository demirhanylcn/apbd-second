using solution.Context;
using solution.Repositories.Abstract;

namespace solution.Repositories;

public class BookGenreRepository : BaseRepository, IBookGenreRepository
{
    public BookGenreRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        
    }
}