using NZWorksAPI.Models.Domain;

namespace NZWorksAPI.Repositories
{
    public interface IUserRepository
    {
        Task<User> AuthenticateAsync(string username, string password);
    }
}
