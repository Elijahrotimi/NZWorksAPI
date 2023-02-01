using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Repositories
{
    public interface IRegionRepository
    {
        IEnumerable<Region> GetAll();
    }
}
