using solution.Context;
using solution.Repositories.Abstract;

namespace solution.Repositories;

public class BookAuthorRepository : BaseRepository, IBookAuthorRepository
{
    public BookAuthorRepository(AppDbContext appDbContext) : base(appDbContext)
    {
        
    }
}