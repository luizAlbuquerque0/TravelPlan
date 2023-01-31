using Microsoft.AspNetCore.Mvc;
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
            _dbContext = dbContext;
        }
        public async Task AddActivitieAsync(Atividade atividade)
        {
            await _dbContext.Atividades.AddAsync(atividade);
        }

        public async Task AddDayBudgetAsync(int id, int budget)
        {
            var viagem = await _dbContext.Viagens.SingleOrDefaultAsync(v => v.Id == id);
            viagem.AddDayBudget(budget);
            await _dbContext.SaveChangesAsync();
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

        public async Task DeleteTravelAsync(int travelId)
        {
            var travel = await _dbContext.Viagens.SingleOrDefaultAsync(v => v.Id == travelId);
            _dbContext.Viagens.Remove(travel);
        }

        public async Task<List<Atividade>> GetAllAtividadesByDate(int idViagem, int date)
        {
            var atividades = await _dbContext.Atividades.Where(v => v.IdViagem == idViagem && v.Date == date).ToListAsync();
            if (atividades == null) return null;
            return atividades;
        }

        public async Task<List<Viagem>> GetUserViagensAsync(int id)
        {
            var viagens = await _dbContext.Viagens.Where(v => v.IdUser == id).ToListAsync();
            if (viagens == null) return null;
            return viagens;
        }

        public async Task<Viagem> GetViagemByIdAsync(int id)
        {
            var viagem = await _dbContext.Viagens.SingleOrDefaultAsync(v => v.Id == id);
            if (viagem == null) return null;
            return viagem;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task UpdateAtividadeAsync(int idViagem, int idAtividade, string Description)
        {
            var atividade = await _dbContext.Atividades.SingleOrDefaultAsync(a => a.Id == idAtividade);
            atividade.ChandeDescription(Description);

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
