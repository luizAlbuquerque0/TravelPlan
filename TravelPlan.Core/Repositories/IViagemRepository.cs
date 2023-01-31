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
        Task<List<Viagem>> GetUserViagensAsync(int id);
        Task<Viagem> GetViagemByIdAsync(int id);
        Task AddDayBudgetAsync(int id, int budget);
        Task WithdrawnAsync(int id, decimal amount);
        Task AddSavedMoneyAsync(int id, decimal amount);
        Task AddActivitieAsync(Atividade atividade);
        Task<List<Atividade>> GetAllAtividadesByDate(int idViagem, int date);
        Task UpdateAtividadeAsync(int idViagem, int idAtividade, string Description);
        Task SaveChangesAsync();
    }
}
