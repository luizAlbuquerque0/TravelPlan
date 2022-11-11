using MediatR;
using TravelPlan.Application.ViewModels;
using TravelPlan.Core.Repositories;

namespace TravelPlan.Application.Queries.GetAtividadeByDate
{
    public class GetAtividadeByDateQueryHandler : IRequestHandler<GetAtividadeByDateQuery, List<AtividadeViewModel>>
    {
        private readonly IViagemRepository _viagemRepository;
        public GetAtividadeByDateQueryHandler(IViagemRepository viagemRepository)
        {
            _viagemRepository = viagemRepository;
        }
        public async Task<List<AtividadeViewModel>> Handle(GetAtividadeByDateQuery request, CancellationToken cancellationToken)
        {
            var atividades = await _viagemRepository.GetAllAtividadesByDate(request.IdViagem, request.Date);
            return atividades.Select(a => new AtividadeViewModel(a.Description, a.StartTime, a.Endtime)).ToList();
        }
    }
}
