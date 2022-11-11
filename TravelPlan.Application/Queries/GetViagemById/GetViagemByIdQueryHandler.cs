using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Application.ViewModels;
using TravelPlan.Core.Entities;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Queries.GetViagemById
{
    public class GetViagemByIdQueryHandler : IRequestHandler<GetViagemByIdQuery, ViagemDetailsViewModel>
    {
        private readonly IViagemRepository _viagemRepository;
        public GetViagemByIdQueryHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }

        public async Task<ViagemDetailsViewModel> Handle(GetViagemByIdQuery request, CancellationToken cancellationToken)
        {
            var viagem = await _viagemRepository.GetViagemByIdAsync(request.Id);
            return new ViagemDetailsViewModel(viagem.Destiny, viagem.Description, viagem.Departure, viagem.Arrival, viagem.DayBudget, viagem.AmountSaved, viagem.AmountWithdrawn);
        }
    }
}
