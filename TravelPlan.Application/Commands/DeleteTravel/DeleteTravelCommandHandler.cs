using MediatR;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.DeleteTravel
{
    public class DeleteTravelCommandHandler : IRequestHandler<DeleteTravelCommand, Unit>
    {
        private readonly IViagemRepository _viagemRepository;
        public DeleteTravelCommandHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }
        public async Task<Unit> Handle(DeleteTravelCommand request, CancellationToken cancellationToken)
        {
            await _viagemRepository.DeleteTravelAsync(request.TravelId);
            await _viagemRepository.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
