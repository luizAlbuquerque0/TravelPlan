using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelPlan.Application.ViewModels;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Queries.GetUserViagens
{
    public class GetUserViagensQueryHandler : IRequestHandler<GetUserViagensQuery, List<ViagensViewModel>>
    {
        private readonly IViagemRepository _viagemRepository;
        public GetUserViagensQueryHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }
        public async Task<List<ViagensViewModel>> Handle(GetUserViagensQuery request, CancellationToken cancellationToken)
        {
            var viagens = await _viagemRepository.GetUserViagensAsync(request.Id);
            var viagensViewModel = viagens.Select(v => new ViagensViewModel(v.Id,v.Destiny, v.Description, v.Departure)).ToList();

            return viagensViewModel;
        }
    }
}
