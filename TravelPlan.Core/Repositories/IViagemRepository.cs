using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Core.Entities;

namespace TravelPlan.Core.Repositories
{
    public interface IViagemRepository
    {
        Task CreateViagemAsync(Viagem viagem);
        Task GetUserViagensAsync(int id);
        Task GetViagemByIdAsync(int id);
        Task AddDayBudgetAsync(int id, int budget);
        Task WithdrawnAsync(int id, int amount);
        Task AddSavedMoneyAsync(int id, int amount);
        Task AddAtividadesAsync(Atividade atividade);
        Task GetAtividadeByIdAsync(int id);
        Task UpdateAtividadeAsync(Atividade atividade);
        Task DeleteAtividadeByIdAsync(int id);
        Task SaveChangesAsync();
    }
}
