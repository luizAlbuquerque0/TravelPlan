using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Core.Entities;

namespace TravelPlan.Core.Repositories
{
    public interface IUserRepository
    {
        Task GetUserByEmailAndPasswordAsync(string email, string password);
        Task CreateUserAsync(User user);
        
        Task SaveChangesAsync();
    }
}
