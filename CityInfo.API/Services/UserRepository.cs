using CityInfo.API.DbContexts;
using CityInfo.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly CityInfoContext _context;
        public UserRepository(CityInfoContext context)
        {
            _context = context;
        }
        public User? GetUser(string name, string password)
        {
            string trimmedName = name.Trim().ToLower();
            return _context.Users
                .Where(u => u.Name == trimmedName && u.Password == password)
                .FirstOrDefault();
        }
    }
}
