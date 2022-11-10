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
            return await _dbContext.Users.SingleOrDefaultAsync(u => u.Email == email && u.Password == password);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
