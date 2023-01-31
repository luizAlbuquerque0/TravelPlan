using MediatR;
using TravelPlan.Core.Entities;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.CreateViagem
{
    public class CreateViagemCommandHandler : IRequestHandler<CreateViagemCommand, int>
    {
        private readonly IViagemRepository _viagemRepository;
        public CreateViagemCommandHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }
        public async Task<int> Handle(CreateViagemCommand request, CancellationToken cancellationToken)
        {
            var viagem = new Viagem(request.Description, request.Destiny, request.Arrival,request.Departure, request.IdUser);
            await _viagemRepository.CreateViagemAsync(viagem);
            await _viagemRepository.SaveChangesAsync();

            return viagem.Id;
        }
    }
}
