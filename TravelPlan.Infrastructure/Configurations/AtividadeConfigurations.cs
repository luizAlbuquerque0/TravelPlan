using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Core.Entities;

namespace TravelPlan.Infrastructure.Configurations
{
    public class AtividadeConfigurations : IEntityTypeConfiguration<Atividade>
    {
        public void Configure(EntityTypeBuilder<Atividade> builder)
        {
            builder
                .HasKey(a => a.Id);

            builder
                .HasOne(a => a.Viagem)
                .WithMany(v => v.Atividades)
                .HasForeignKey(a => a.IdViagem)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
