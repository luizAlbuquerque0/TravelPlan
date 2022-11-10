using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Core.Entities;

namespace TravelPlan.Infrastructure.Persistence
{
    public class TravelPlanDbContext : DbContext
    {
        public TravelPlanDbContext(DbContextOptions<TravelPlanDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Viagem> Viagens { get; set; }
        public DbSet<Atividade> Atividades { get; set; }

       protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
