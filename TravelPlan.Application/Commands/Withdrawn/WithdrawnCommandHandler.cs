using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.Withdrawn
{
    internal class WithdrawnCommandHandler : IRequestHandler<WithdrawnCommand, Unit>
    {
        private readonly IViagemRepository _viagemRepository;
        public WithdrawnCommandHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }
        public async Task<Unit> Handle(WithdrawnCommand request, CancellationToken cancellationToken)
        {
            await _viagemRepository.WithdrawnAsync(request.Id, request.Amount);
            return Unit.Value;
        }
    }
}
