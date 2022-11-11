using MediatR;
using TravelPlan.Application.ViewModels;

namespace TravelPlan.Application.Queries.GetAtividadeByDate
{
    public class GetAtividadeByDateQuery : IRequest<List<AtividadeViewModel>>
    {
        public int IdViagem { get; set; }
        public int Date { get; set; }
    }
}
