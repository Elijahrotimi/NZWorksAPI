using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
    }
}
