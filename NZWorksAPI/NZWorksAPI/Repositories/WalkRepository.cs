using Microsoft.EntityFrameworkCore;
using NZWorksAPI.Data;
using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Repositories
{
    public class WalkRepository : IWalkRepository
    {
        private readonly NZWalksDbContext nZWalksDbContext;

        public WalkRepository(NZWalksDbContext nZWalksDbContext)
        {
            this.nZWalksDbContext = nZWalksDbContext;
        }
        public async Task<IEnumerable<Walk>> GetAllAsync()
        {
            return await nZWalksDbContext.Walks.ToListAsync();
        }

    }
}
