using solution.Context;
using solution.Repositories.Abstract;

namespace solution.Repositories;

public class PublishingHouseRepository : BaseRepository, IPublishingHouseRepository
{
 public PublishingHouseRepository(AppDbContext appDbContext) : base(appDbContext)
 {
  
 }
}