using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Repositories
{
    public interface IWalkRepository
    {

        Task<IEnumerable<Walk>> GetAllAsync();

        Task<Walk> GetAsync(Guid id);
    }
}
