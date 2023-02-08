using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Repositories
{
    public interface ITokenHandler
    {
        Task<string> CreateTokenAsync(User user);
    }
}
