using MediatR;
using TravelPlan.Core.Entities;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.AddActivitie
{
    public class AddActivitieCommandHandler : IRequestHandler<AddActivitieCommand, Unit>
    {
        private readonly IViagemRepository _viagemRepository;
        public AddActivitieCommandHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }
        public async Task<Unit> Handle(AddActivitieCommand request, CancellationToken cancellationToken)
        {
            var activitie = new Atividade(request.Description, request.StatTime, request.EndTime, request.Date, request.TravelId);
            await _viagemRepository.AddActivitieAsync(activitie);

            return Unit.Value;
        }
    }
}
