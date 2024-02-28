using CityInfo.API.Entities;

namespace CityInfo.API.Services
{
    public interface IUserRepository
    {
        User? GetUser(string name, string password);
    }
}
