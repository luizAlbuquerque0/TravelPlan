using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Commands.AddDayBudget
{

    public class AddDayBudgetCommandHandler : IRequestHandler<AddDayBudgetCommand, Unit>
    {
        private readonly IViagemRepository _viagemRepository;
        public AddDayBudgetCommandHandler(IViagemRepository viagemRepositoy)
        {
            _viagemRepository = viagemRepositoy;
        }

        public async Task<Unit> Handle(AddDayBudgetCommand request, CancellationToken cancellationToken)
        {
            await _viagemRepository.AddDayBudgetAsync(request.Id, request.budget);
            return Unit.Value;
        }
    }
}
