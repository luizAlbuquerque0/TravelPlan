using Microsoft.EntityFrameworkCore;
using TravelPlan.Core.Entities;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Infrastructure.Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly TravelPlanDbContext _dbContext;
        public UserRepository(TravelPlanDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task CreateUserAsync(User user)
        {
            var userExist = await _dbContext.Users.SingleOrDefaultAsync(u => u.Email == user.Email);
            if (userExist != null) return;

            await _dbContext.Users.AddAsync(user);
        }

        public async Task<User> GetUserByEmailAndPasswordAsync(string email, string password)
        {
            var user =  await _dbContext.Users.SingleOrDefaultAsync(u => u.Email == email && u.Password == password);
            if (user == null) return null;

            return user;
        }

        public async Task<User> GetUserByIdAsync(int id)
        {
            var user = await _dbContext.Users.SingleOrDefaultAsync(u => u.Id == id);
            if (user == null) return null;
            return user;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
