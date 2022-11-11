using MediatR;
using TravelPlan.Application.ViewModels;
using TravelPlan.Core.Entities;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.CreateViagem
{
    public class CreateViagemCommandHandler : IRequestHandler<CreateViagemCommand, ViagemDetailsViewModel>
    {
        private readonly IViagemRepository _viagemRepository;
        public CreateViagemCommandHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }
        public async Task<ViagemDetailsViewModel> Handle(CreateViagemCommand request, CancellationToken cancellationToken)
        {
            var viagem = new Viagem(request.Description, request.Destiny, request.Arrival,request.Departure, request.IdUser);
            await _viagemRepository.CreateViagemAsync(viagem);

            return new ViagemDetailsViewModel(viagem.Destiny, viagem.Description, viagem.Departure, viagem.Arrival, viagem.DayBudget, viagem.AmountSaved, viagem.AmountSaved);
        }
    }
}
