using MediatR;
using TravelPlan.Application.ViewModels;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.UpdateAtividade
{
    public class UpdateAtividadeCommandHandler : IRequestHandler<UpdateAtividadeCommand, Unit>
    {
        private readonly IViagemRepository _viagemRepository;
        public UpdateAtividadeCommandHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }

        public async Task<Unit> Handle(UpdateAtividadeCommand request, CancellationToken cancellationToken)
        {
            await _viagemRepository.UpdateAtividadeAsync(request.IdViagem, request.IdAtividade, request.Description);
            await _viagemRepository.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
