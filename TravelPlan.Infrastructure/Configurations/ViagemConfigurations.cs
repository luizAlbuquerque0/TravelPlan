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
    public class ViagemConfigurations : IEntityTypeConfiguration<Viagem>
    {
        public void Configure(EntityTypeBuilder<Viagem> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .HasOne(x => x.User)
                .WithMany(u => u.Viagens)
                .HasForeignKey(x => x.IdUser)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
