using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Core.Entities;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Infrastructure.Persistence.Repositories
{
    public class ViagemRepository : IViagemRepository
    {
        private readonly TravelPlanDbContext _dbContext;
        public ViagemRepository(TravelPlanDbContext dbContext)
        {
            dbContext = _dbContext;
        }
        public async Task AddAtividadesAsync(Atividade atividade)
        {
            await _dbContext.Atividades.AddAsync(atividade);
        }

        public async Task AddDayBudgetAsync(int id, int budget)
        {
            var viagem = await _dbContext.Viagens.SingleOrDefaultAsync(v => v.Id == id);
            viagem.AddDayBudget(budget);
            _dbContext.SaveChangesAsync();
        }

        public async Task AddSavedMoneyAsync(int id, decimal amount)
        {
            
            var viagem = await _dbContext.Viagens.SingleOrDefaultAsync(v => v.Id == id);
            viagem.AmountSaved += amount;
        }

        public async Task CreateViagemAsync(Viagem viagem)
        {
            await _dbContext.Viagens.AddAsync(viagem);
            
        }

        public Task DeleteAtividadeByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Atividade>> GetAllAtividadesByViagem(int id)
        {
            var atividades = await _dbContext.Atividades.Where(a => a.IdViagem == id).ToListAsync();
            if (atividades == null) return null;
            return atividades;
        }

        public async Task<Atividade> GetAtividadeByIdAsync(int id)
        {
            return await _dbContext.Atividades.SingleOrDefaultAsync(a => a.Id == id);
        }

        public async Task<List<Viagem>> GetUserViagensAsync(int id)
        {
            var viagens = await _dbContext.Viagens.Where(v => v.IdUser == id).ToListAsync();
            if (viagens == null) return null;
            return viagens;
        }

        public async Task<Viagem> GetViagemByIdAsync(int id)
        {
            return await _dbContext.Viagens.SingleOrDefaultAsync(v => v.Id == id);
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public Task UpdateAtividadeAsync(Atividade atividade)
        {
            throw new NotImplementedException();
        }

        public async Task WithdrawnAsync(int id, decimal amount)
        {
            var viagem = await _dbContext.Viagens.SingleOrDefaultAsync(v => v.Id == id);
            if (amount > viagem.AmountSaved) return;
            viagem.AmountSaved -= amount;
            viagem.AmountWithdrawn += amount;
        }
    }
}
