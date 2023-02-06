using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Repositories
{
    public interface IWalkDifficultyRepository
    {
        Task<IEnumerable<WalkDifficulty>> GetAllAsync();
    }
}
