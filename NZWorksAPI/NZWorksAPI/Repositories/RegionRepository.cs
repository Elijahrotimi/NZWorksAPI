using NZWorksAPI.Data;
using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public RegionRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public IEnumerable<Region> GetAll()
        {
            return nZWalksDbContext.Regions.ToList();
        }
    }
}
