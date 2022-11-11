using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.AddSavedMoney
{
    public class AddSavedMoneyCommandHandler : IRequestHandler<AddSavedMoneyCommand, Unit>
    {
        private readonly IViagemRepository _viagemRepository;
        public AddSavedMoneyCommandHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }
        public async Task<Unit> Handle(AddSavedMoneyCommand request, CancellationToken cancellationToken)
        {
            await _viagemRepository.AddSavedMoneyAsync(request.Id, request.Amount);
            return Unit.Value;
        }
    }
}
